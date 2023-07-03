using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using BackgroundServicesDemo.Controllers;
using System.Collections;

namespace BackgroundServicesDemo.Workers
{
    public class QueueConsumerWorker: BackgroundService
    {
        
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // keep looping until we get a cancellation request
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    // todo: Add repeating code here
                    // add a delay to not run in a tight loop
                    Debug.Print("Just another iteraction");
                    if(StatusController.dataCollection != null) {
                        if (StatusController.dataCollection.Count > 0) { 
                            Debug.Print("Start queue process");
                            Queue data = StatusController.dataCollection;
                            StatusController.dataCollection.Clear();
                            Debug.Print("Serials to process: "+data.Count);
                            foreach (var item in data)
                            {
                                Debug.Print("Data: "+item);
                            }
                            data.Clear();
                        }
                    }
                    await Task.Delay(1000, stoppingToken);
                }
                catch (OperationCanceledException)
                {
                    // catch the cancellation exception
                    // to stop execution
                    return;
                }
            }
        }
    }
}
