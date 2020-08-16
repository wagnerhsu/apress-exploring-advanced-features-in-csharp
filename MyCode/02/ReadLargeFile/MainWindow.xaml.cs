using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace ReadLargeFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnRead_Click(object sender, RoutedEventArgs e)
        {
            int linesInFile = await ReadFileAsync();
            txtTotalLine.Text = linesInFile.ToString();
        }

        private async Task<int> ReadFileAsync()
        {
            var FileLines = new List<string>();
            int lineCount = 0;

            using (var reader = File.OpenText(@"C:\temp\Dgw.DBMonitor.log"))
            {
                string line = string.Empty;
                while ((line = await reader.ReadLineAsync().ConfigureAwait(false)) != null)
                {
                    FileLines.Add(line);
                    lineCount += 1;

                    txtReadLine.Dispatcher.Invoke(new Action(() => txtReadLine.Text = lineCount.ToString()));
                }
            }

            return lineCount;
        }
    }
}