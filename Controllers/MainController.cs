using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Withus.Forms;
using Withus.Utilitys;
using Withus.Views;

namespace Withus.Controllers
{
    class MainController
    {
        IMainView mainView { get; set; }

        MainForm main;

        public string gamezone_Result = string.Empty;
        public string today_Result = string.Empty;
        public string[] naver_Result = new string[2];

        public MainController(IMainView mainView)
        {
            this.mainView = mainView;
            main = (MainForm)mainView;
            mainView.HelperProcessStart += HelperProcess;
            mainView.HelperProcessStop += HelperThreadStop;
        }

        private void HelperProcess(object sender, EventArgs e)
        {
            main.isHelperRunning = true;
            main.toolStripMenuItem_ProcessStart.Enabled = false;
            main.toolStripMenuItem_ProcessStop.Enabled = true;
            Thread thread = new Thread(new ThreadStart(HelperThread));
            thread.Start();
        }
        private void HelperThread()
        {
            //main.Invoke(new Action(() => main.MessageAppender($"{i}회 테스트"))); 

            Thread gamezoneThread = new Thread(new ThreadStart(GameZoneWorker));
            gamezoneThread.Start();

            Thread todayThread = new Thread(new ThreadStart(TodayWorker));
            todayThread.Start();

            //Thread naverThread = new Thread(new ThreadStart(NaverWorker));
            //naverThread.Start();

            // IMG + TEXT = POSTER            
            /* 1. 실행 경로에서 POSTER를 가져온다.
             * 버전 87.0.4280.66(공식 빌드) (64비트)
             * 2. 셀레니움(?) 드라이버 열고 바인딩들을 한다.
             * 3. 핸들링들을 한다.
             * 4. 링크 주소들을 반환하며 종료한다.
             */
        }

        private void NaverWorker()
        {
            int count = 0;
            while (true)
            {
                string result = new Crawler().NaverHeler();
                count++;
                main.Invoke(new Action(() => main.MessageAppender($"{count} : {result}")));
                Thread.Sleep(1000);
            }
        }

        private void TodayWorker()
        {
            string result = new Crawler().TodayHelper(main.todayAccount, main.todayPassword, main.needView1);
            ReturnResult(InputManager.InfoTypes.Today, result);
        }

        private void GameZoneWorker()
        {            
            string result = new Crawler().GamezoneHeler(main.gamezoneAccount, main.gamezonePassword, main.needView);            
            ReturnResult(InputManager.InfoTypes.Gamezone, result);            
        }

        private void ReturnResult(InputManager.InfoTypes types, string result)
        {
            switch (types)
            {
                case InputManager.InfoTypes.Gamezone:
                    if (result.Contains("포인트 부족 또는 기타오류"))
                        main.Invoke(new Action(() => main.MessageAppender($"[게임존]오류발생 : {result}")));                   
                    else                   
                        main.Invoke(new Action(() => main.MessageAppender($"[게임존]완료 : {result}")));                    
                    break;
                case InputManager.InfoTypes.Today:
                    if (result.Contains("포인트 부족 또는 기타오류"))
                        main.Invoke(new Action(() => main.MessageAppender($"[투데이서버]오류발생 : {result}")));
                    else
                        main.Invoke(new Action(() => main.MessageAppender($"[투데이서버]완료 : {result}")));
                    break;
            }
        }
        private void HelperThreadStop(object sender, EventArgs e)
        {
            //무한뤂 돌게 아니니 의미없음.
            //main.isHelperRunning = false;
            //main.toolStripMenuItem_ProcessStart.Enabled = true;
            //main.toolStripMenuItem_ProcessStop.Enabled = false;
            MessageBox.Show("해당 프로세스에서는 지원하지 않습니다.\n 프로그램을 종료하여 프로세스를 닫습니다.");
            main.ProcessKill();
        }
    }
}
