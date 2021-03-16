// To run this example, see Building examples that have static TextBlock controls for Windows Phone 8.

using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Controls;

class Example
{
    const int MAX_ITERATIONS = 100;

    // Example data: A BackgroundWorker that reports progress to the user 
    // interface thread, the queue that is protected by the lock, and a
    // random number generator.
    private BackgroundWorker m_worker = new BackgroundWorker();
    private Queue<int> m_smplQueue = new Queue<int>();
    private Random m_random = new Random();

    // This thread does work and produces a result (in this case just a
    // number).
    private void Producer()
    {
        int counter = 0;
        lock (m_smplQueue)
        {
            while (counter < MAX_ITERATIONS)
            {
                // Wait, if the queue is busy.
                Monitor.Wait(m_smplQueue);

                // Simulate a small amount of work, then queue one element
                // and release the waiting thread.
                Thread.Sleep(10 + m_random.Next(10));
                m_smplQueue.Enqueue(counter);
                Monitor.Pulse(m_smplQueue);

                counter += 1;
            }
        }
    }

    // This thread consumes the result produced by the first thread. It 
    // could do additional processing, but in this case it just reports
    // the number.
    private void Consumer()
    {
        lock (m_smplQueue)
        {
            // Release the waiting thread.
            Monitor.Pulse(m_smplQueue);

            // Wait in the loop while the queue is busy.
            // Exit on the time-out when the first thread stops. 
            while (Monitor.Wait(m_smplQueue, 1000))
            {
                // Pop the first element.
                int counter = (int)m_smplQueue.Dequeue();

                // Print the first element.
                m_worker.ReportProgress(0, String.Format("{0} ", counter));

                // Release the waiting thread.
                Monitor.Pulse(m_smplQueue);
            }
        }
    }


    // -------------------
    // This section contains supporting code that runs the example on a
    // background thread, so it doesn't block the UI thread, and enables
    // the example to display output using Windows Phone UI elements. There
    // is no example code for Monitor in this section.

    // This UI element receives the output from the example. It's the same
    // for all instances of Example.
    private static TextBlock outputBlock;

    // A list of all Example objects that are currently running. 
    private static List<Example> examples = new List<Example>();

    // The Demo method saves the TextBlock used for output, and sets up a
    // mouse event that you click to run instances of the demonstration.
    //
    public static void Demo(TextBlock outputBlock)
    {
        Example.outputBlock = outputBlock;
        outputBlock.Text += "Click here to begin running the example.\r\n";

        // Set up an event handler to run the example when the TextBlock 
        // is clicked.
        outputBlock.MouseLeftButtonUp += MouseUp;
    }

    // This mouse event gives visual feedback and starts a new instance of
    // Example. The instance must be started on the UI thread, so that the
    // BackgroundWorker raises its events on the UI thread.
    //
    private static void MouseUp(object sender, MouseButtonEventArgs e)
    {
        outputBlock.Text += "<Click> ";
        examples.Add(new Example());
    }


    // Each new Example sets up the events for its background task and
    // launches the task. It also creates a unique ID number.
    //
    private int m_id;
    private static int lastId = 0;
    public Example()
    {
        m_id = Interlocked.Increment(ref lastId);

        m_worker.DoWork += this.RunExample;
        m_worker.WorkerReportsProgress = true;
        m_worker.ProgressChanged += this.Progress;
        m_worker.RunWorkerCompleted += this.Completed;
        m_worker.RunWorkerAsync();
    }

    // Launch the producer and consumer threads.
    private void RunExample(object sender, DoWorkEventArgs e)
    {

        // Create the threads and start them.
        Thread tProducer = new Thread(this.Producer);
        Thread tConsumer = new Thread(this.Consumer);
        tProducer.Start();
        Thread.Sleep(1);
        tConsumer.Start();

        // Wait until the two threads end.
        tProducer.Join();
        tConsumer.Join();

        // When the task completes, return the Example object.
        e.Result = this;
    }

    // The display output that is queued using the ReportProgress method
    // is delivered to the UI thread by this event handler.
    //
    private void Progress(object sender, ProgressChangedEventArgs e)
    {
        // This code is executed on the main UI thread, so it's safe to 
        // access the UI elements.
        outputBlock.Text += e.UserState.ToString();
    }

    // This event handler signals task completion to the UI thread. It 
    // removes the Example object from the list and displays its count.
    //
    private void Completed(object sender, RunWorkerCompletedEventArgs e)
    {
        examples.Remove(this);
        outputBlock.Text += String.Format("<Example({0}) Queue Count = {1}> ",
                                          m_id, m_smplQueue.Count);
    }
}

/* This code produces output similar to the following:

Click here to begin running the example.
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 
30 <Click> 31 32 33 0 34 1 35 2 36 3 37 38 4 5 39 6 40 7 41 8 42 43 9 10 44 45 11
46 12 13 47 48 14 49 15 50 16 51 17 52 18 53 19 54 20 55 21 56 22 57 23 24 58 25
59 26 60 27 28 61 29 62 30 31 63 64 32 33 65 34 66 35 67 36 68 37 69 38 39 70 71 
40 41 72 42 73 74 43 75 44 76 77 45 46 78 47 79 48 80 49 81 50 82 51 83 52 84 53
85 54 86 55 87 56 88 57 89 58 90 59 91 60 92 61 93 62 94 63 95 64 65 96 97 66 98
67 99 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92
93 94 95 96 97 98 99 <Example(1) Queue Count = 0> <Example(2) Queue Count = 0> 
 */
