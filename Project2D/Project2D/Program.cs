using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jong2D;
using Jong2D.Utility;

namespace Project2D
{
    class Program
    {
        //Screen dimension constants
        private const int SCREEN_WIDTH = 800;
        private const int SCREEN_HEIGHT = 480;
        private static List<IResource> Resources = new List<IResource>();


        static void Main(string[] args)
        {
            Context.CreateWindow(Program.SCREEN_WIDTH, Program.SCREEN_HEIGHT);
            // 종료 이벤트 등록
            Context.OnClosed += Close;

            // 리소스 생성 : 리소스 = 파일
            // 1. 리소스를 찾으려면 절대경로 / 상대경로로 실제로 찾을 수 있어야 한다
            // 절대 경로 : 모든 경로를 다 적는거
            // 상대 경로 : 프로그램 시작 위치 기준으로 경로

            Font font = Context.LoadFont(@"Resources\ConsolaMalgun.TTF", 16);
            Image grass = Context.LoadImage(@"Resources\grass.png");
            Image character = Context.LoadImage(@"Resources\character.png");
            Music music = Context.LoadMusic(@"Resources\background.mp3");

            Resources.Add(font);
            Resources.Add(grass);
            Resources.Add(character);
            Resources.Add(music);

            // 게임 루프
            //music.PlayRepeat();

            var pos = new Vector2D(0, 80);
            var pos2 = new Vector2D(700, 80);
            while (pos.x < 800)
            {
                // 이벤트 처리
                Context.GetGameEvents();

                // 로직 처리
                pos.x += 5;
                pos2.x -= 5;

                // 화면 초기화
                Context.ClearWindow();

                // 렌더링 
                font.Render(100, 300, "Sample1", new Color(100, 25, 25));
                grass.Render(Program.SCREEN_WIDTH / 2, 30);
                character.Render(pos);
                character.Render(pos2);

                // 페이지 플리핑
                Context.UpdateWindow();

                Context.Delay(0.05);
            }

            Context.CloseWindow();
        }

        static void Close()
        {
            Console.WriteLine("Close!");
            foreach (var resource in Resources)
            {
                resource.Dispose();
            }
        }
    }
}
