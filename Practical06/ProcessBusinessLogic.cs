public delegate void Notify();
class ProcessBusinessLogic
{
    public event Notify ProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        Console.WriteLine("Process is running......");
        OnProcessCompleted();
    }

    protected virtual void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }

    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Method Invoked!");
    }

    static void Main(string[] args)
    {
        ProcessBusinessLogic pbl = new ProcessBusinessLogic();
        pbl.ProcessCompleted += bl_ProcessCompleted;
        pbl.StartProcess();
    }
}