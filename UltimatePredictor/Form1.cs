using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace UltimatePredictor
{
    public partial class Form1 : Form
    {
        private const string appName = "Ultimate Pretictor";
        private readonly string predictionsConfigPath = $"{Environment.CurrentDirectory}\\predictionsConfig.json";
        private string[] predictions;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обрабатыает нажатие кнопки bPredict
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bPredict_Click(object sender, EventArgs e)
        {
            bPredict.Enabled = false;
            //Включаем ассинхронное выполнение заполнения progressBar
           await Task.Run(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    //Action - делегат для модификации данных из другого потока
                    Invoke(new Action(() =>
                        {
                            UpdateProgressBar(i);
                            this.Text = $"{i}%";
                        }));
                    Thread.Sleep(50);
                }
            });
            var index = random.Next(predictions.Length);
            var prediction = predictions[index];
            MessageBox.Show($"{prediction}");
            progressBar1.Value = 0;
            this.Text = appName;
            bPredict.Enabled = true;
        }
        /// <summary>
        /// Синхронизирует значение ProgressBar со значением текущего итератора.
        /// Позволяет воспроизводить анимацию заполнения ProgressBar синхронно с выполнением потока.
        /// </summary>
        /// <param name="i">Итератор (текущее значение прогресс-бара)</param>
        private void UpdateProgressBar(int i)
        {
            /// Если текущее значение уже равно максимальному в ProgressBar, то обнуляем положение
            /// ProgressBar и присваеваем ему текущее положение итератора
            if (i==progressBar1.Maximum)
            {
                progressBar1.Maximum = i + 1;
                progressBar1.Value = i + 1;
                progressBar1.Maximum = i;
            }
            else
            {
                progressBar1.Value = i + 1;
            }
        }
        /// <summary>
        /// Обрабатывает нажание кнопки bMessageInfo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMessageInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет!\n" + "   Я искусственный разум, который предсказывает будущее...\n" + "   Просто загадай вопрос (с ответом ДА или НЕТ), а я отвечу...\nPREDICT - ПРЕДСКАЗАТЬ\n\n"+ "Hello!\n   " +
                " I have an artificial mind that predicts the future ...\n    Just make a question  (with YES or NO), and I will answer ...\n\n\n\n (c)Created by Skirko Alex", "Обо мне///About me");
        }
        /// <summary>
        /// Обрабатывает загрузку формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = appName;
            try
            {
                var data = File.ReadAllText(predictionsConfigPath);
                predictions = JsonConvert.DeserializeObject<string[]>(data);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (predictions==null)
                {
                    Close();
                }
                else if (predictions.Length == 0)
                {
                    MessageBox.Show("Предсказания закончились, увы =(");
                    Close();
                }
            }
        }
    }
}
