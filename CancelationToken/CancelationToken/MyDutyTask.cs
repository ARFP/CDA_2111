using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancelationToken
{
    internal class MyDutyTask
    {
        public int counterToShow;
        private CancellationTokenSource cancelToken;

        public MyDutyTask()
        {
            cancelToken = new CancellationTokenSource();
            counterToShow = 0;
        }

        public void Start()
        {
            Task.Run(() => BackgroundAction());
        }

        public void BackgroundAction()
        {
            try
            {
                do
                {
                    Thread.Sleep(1000);
                    cancelToken.Token.ThrowIfCancellationRequested();
                    counterToShow++;
                    Debug.WriteLine(counterToShow);
                } while (true);
            }
            catch(OperationCanceledException)
            {
                cancelToken.Dispose();
            }
        }

        public void Stop()
        {
            cancelToken.Cancel();
        }
    }
}
