// defining delegate Notify()
public delegate void Notify();

// ProcessBusinessLogic class
class ProcessBusinessLogic
{
    // defining ProcessCompleted event
    public event Notify ProcessCompleted;

    // start process method which call OnProcessCompleted() method
    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        Console.WriteLine("Process is running......");
        OnProcessCompleted();
    }

    // OnProcessCompleted() method which invokes ProcessCompleted event
    protected virtual void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }

    // bl_ProcessCompleted() method which called when method invoked
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Method Invoked!");
    }

    // main method which creates instance of ProcessBusinessLogic class and attach event with it
    static void Main(string[] args)
    {
        ProcessBusinessLogic pbl = new ProcessBusinessLogic();
        pbl.ProcessCompleted += bl_ProcessCompleted;
        pbl.StartProcess();
    }
}