using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreater
{
    class Program
    {
        static readonly string ABSPATH = System.Environment.CurrentDirectory + "\\" + "생성된 폴더";

        static void Main(string[] args)
        {
            int fileCount;

            Console.WriteLine("만들 폴더의 갯수를 입력하세요. 예: 1 2 3\n");
            fileCount = int.Parse(Console.ReadLine());

            CreateFolders(fileCount);

            Console.WriteLine("프로그램을 종료 하시려면 아무키나 눌러주세요. \n");
            Console.ReadKey();
        }

        private static void CreateFolders(int cnt)
        {
            DirectoryInfo dir = new DirectoryInfo(ABSPATH);
            if (!dir.Exists)
            {
                //폴더 생성
                Console.WriteLine("상위폴더가 없어 먼저 생성 하였습니다... \n");
                dir.Create();
            }

            //폴더 있음
            for (int i = 0; i < cnt; i++)
            {
                dir = new DirectoryInfo(ABSPATH + "\\" + (i + 1));
                Console.WriteLine((i + 1) + " 번째 폴더 생성");

                if (dir.Exists)
                {
                    Console.WriteLine("같은 이름의 폴더가 있어 건너 뛰었습니다. 파일이름: " + dir.FullName);
                }
                else
                {
                    dir.Create();
                }
            }

            Console.WriteLine("폴더를 모두 생성하였습니다.");
        }
    }
}
