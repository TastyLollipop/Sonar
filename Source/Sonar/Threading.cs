using System.Threading;

namespace Sonar
{
    public class Threading
    {
        public int networkThreadCount = 0;

        //Generate threads in charge of managing the utils class
        public void GenerateThread(int threadID)
        {
            switch (threadID)
            {
                case 0:
                    Thread utilsThread = new Thread(new ThreadStart(Sonar.utils.GenerateNetworkInstances));
                    utilsThread.IsBackground = true;
                    utilsThread.Name = "Utils Thread";
                    utilsThread.Start();
                    break;

                case 1:
                    Thread timerThread = new Thread(new ThreadStart(Sonar.utils.StartTimer));
                    timerThread.IsBackground = true;
                    timerThread.Name = "Timer Thread";
                    timerThread.Start();
                    break;

                case 2:
                    Thread countThread = new Thread(new ThreadStart(Sonar.utils.StartCounter));
                    countThread.IsBackground = true;
                    countThread.Name = "Count Thread";
                    countThread.Start();
                    break;
            }
        }

        //Generate threads required to scan the ports
        public void GenerateNetworkThread(Networking instance)
        {
            Thread scanThread = new Thread(new ThreadStart(instance.ScanPort));
            scanThread.IsBackground = true;
            scanThread.Name = "Scan Thread";
            scanThread.Start();

            networkThreadCount++;
        }
    }
}
