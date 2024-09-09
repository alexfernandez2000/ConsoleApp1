using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
       private enum eCellStatus
        {
            Empty,
            Head,
            Body,
            BodyHead,
            Fruit,
        }

        private static readonly IEnumerable<IEnumerable<eCellStatus>> board = new List<IEnumerable<eCellStatus>>();
        static void Main(string[] args)
        {
            while (true)
            {
                
            }
        }

        private void ShowBoar()
        {
            foreach (IEnumerable<eCellStatus> list in board)
            {
                foreach (eCellStatus eCellStatus in list)
                {
                    string line="";
                    switch (eCellStatus)
                    {
                        case eCellStatus.Empty:
                            line += " ";
                            break;
                            default:
                            line += " ";
                            break;
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
