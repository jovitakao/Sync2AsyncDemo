using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sync2AsyncDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string _initMessage = "Starting ... ";
        private const string _returnMessage = "Hello World";
        private const int _sleepNumber = 3000;


        private void demo1_Click(object sender, EventArgs e)
        {
            //Block UI 3 seconds
            lblResult.Text = _initMessage;
            lblResult.Update();
            Thread.Sleep(_sleepNumber);
            lblResult.Text = _returnMessage;
        }

        private void demo2_Click(object sender, EventArgs e)
        {
            //Block UI 3 seconds
            lblResult.Text = _initMessage;
            var task = Task.Run(()=> {
                Thread.Sleep(_sleepNumber);
                return _returnMessage;
            });
            lblResult.Text = task.Result;
        }

        private void demo3_Click(object sender, EventArgs e)
        {
            lblResult.Text = _initMessage;
            var task = Task.Run(() => {
                Thread.Sleep(_sleepNumber);
                return _returnMessage;
            });
            task.ContinueWith(
                (completedTask) =>
                {
                    lblResult.Text = completedTask.Result;
                }
                );
        }

        private void demo4_Click(object sender, EventArgs e)
        {
            //4.Non block UI, with exception
            lblResult.Text = _initMessage;
            var task = Task.Run(
                () =>
                {
                    Thread.Sleep(_sleepNumber);
                    throw new Exception("Task Error");
                    return _returnMessage;
                }
                );

            task.ContinueWith(
                (completedTask) =>
                {
                    lblResult.Text = completedTask.Result;
                }
                );
        }

        private void demo5_Click(object sender, EventArgs e)
        {
            //5.Non block UI, with exception handle
            lblResult.Text = _initMessage;
            var task = Task.Run(
                () =>
                {
                    Thread.Sleep(_sleepNumber);
                    throw new Exception("Task Error");
                    return _returnMessage;
                }
                );

            task.ContinueWith(
                (completedTask) =>
                {
                    if (completedTask.IsFaulted)
                    {
                        Console.WriteLine(completedTask.Exception.ToString());
                    }
                    else
                    {
                        lblResult.Text = completedTask.Result;
                    }

                }
                );
        }

        private void demo6_Click(object sender, EventArgs e)
        {
            //6.Non block ui , 設定切到 UI Thread
            lblResult.Text = _initMessage;
            var task = Task.Run(
                () =>
                {
                    Thread.Sleep(_sleepNumber);
                    return _returnMessage;
                }
                );
            ////if the current execution context is on the UI thread.
            //task.ContinueWith(
            //    (completedTask) =>
            //    {
            //        lblResult.Text = completedTask.Result;
            //    }
            //    , TaskScheduler.FromCurrentSynchronizationContext());
            task.ContinueWith(
                (completedTask) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblResult.Text = completedTask.Result;
                    });
                }
                );
        }

        private async void demo7_Click(object sender, EventArgs e)
        {
            //7.Non block ui ,async await
            lblResult.Text = _initMessage;
            var task = Task.Run(
                () =>
                {
                    Thread.Sleep(_sleepNumber);
                    return _returnMessage;
                }
                );
            lblResult.Text = await task;
        }

        private async void demo8_Click(object sender, EventArgs e)
        {
            //8.Non block ui, async await with Exception
            lblResult.Text = _initMessage;
            var task = Task.Run(
                () =>
                {
                    Thread.Sleep(_sleepNumber);
                    throw new Exception("async inner exception");
                    //no error handle app crash ...
                    return _returnMessage;
                }
                );
            lblResult.Text = await task;

        }

        private void demo9_Click(object sender, EventArgs e)
        {
            //9.搬到 RunAsync Method，並用 try catch 包，但不會進去
            //主要是因為 RunAsync 回傳是void
            lblResult.Text = _initMessage;
            try
            {
                RunAsync();
            }
            catch (Exception ex)
            {
                //won't run ...
                Console.WriteLine(ex.ToString());
            }
        }

        private async void RunAsync()
        {
            var task = Task.Run(
                () =>
                {
                    Thread.Sleep(_sleepNumber);
                    throw new Exception("async inner exception");
                    return _returnMessage;
                }
                );
            lblResult.Text = await task;
        }

        private void demo10_Click(object sender, EventArgs e)
        {
            //10.搬到 RunAsync2 Method，並用 try catch 包，
            //這次不會錯了，但是因為沒有await，所以攔不到了
            lblResult.Text = _initMessage;
            try
            {
                RunAsyncReturnTask();
            }
            catch (Exception ex)
            {
                //won't run ...
                Console.WriteLine(ex.ToString());
            }
        }

        private async Task RunAsyncReturnTask()
        {
            var task = Task.Run(
                () =>
                {
                    Thread.Sleep(_sleepNumber);
                    throw new Exception("async inner exception");
                    return _returnMessage;
                }
                );
            lblResult.Text = await task;
        }

        private async void demo11_Click(object sender, EventArgs e)
        {
            //11.搬到 RunAsync2 Method，並用 try catch 包，
            //因為加了await，所以攔到了
            lblResult.Text = _initMessage;
            try
            {
                await RunAsyncReturnTask();
            }
            catch (Exception ex)
            {
                //will run ...
                Console.WriteLine(ex.ToString());
            }
        }

        private void demo12_Click(object sender, EventArgs e)
        {
            //deadlock Wait & ContinueWith FromCurrentSynchronizationContext
            Task.Delay(1)
                .ContinueWith((t) => {}
                , TaskScheduler.FromCurrentSynchronizationContext()
                ).Wait();
        }
    }
}
