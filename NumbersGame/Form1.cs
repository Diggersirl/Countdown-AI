using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Threader = System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersGame
{
    public partial class Form1 : Form
    {
        public int Goal { get; set; }
        public HashSet<int> Numbers { get; set; }
        private int Countdown { get; set; }
        private Tuple<int[], string[], int> ComputerResults { get; set; }
        Timer timer = new Timer();
        Algorithm a;
        EasyAlgorithm ea;
        private bool OpenBracketDisabled = false;
        private string PlayerEq;

        public static int PlayerScore { get; set; }
        public static int ComputerScore { get; set; }
        public static int RoundNo = 1;
        public static string Difficulty = "normal";

        public delegate Tuple<int[], string[], int> GetComputerAnswer();
        GetComputerAnswer gca;


        private int PlayerResult { get; set; }

        private List<int> PlayerOperands;
        private List<string> PlayerOperators;
        private List<Button> UsedNumbers = new List<Button>();

        public Form1(int largeNums, int smallNums)
        {
            InitializeComponent();
            Random r = new Random();
            StringBuilder sb = new StringBuilder();     

            Goal = r.Next(100, 1000);
            Numbers = GetNumbers(largeNums, smallNums);

            lblGoalDisplay.Text = Goal.ToString();
            lblDifficulty.Text += " " + Difficulty;
        }

        private void InitRound()
        {
            Countdown = 60;
            int i = 0;
            int[] numbers = Numbers.ToArray();
            

            PlayerOperands = new List<int>();
            PlayerOperators = new List<string>();

            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            lblPlayerScoreDisplay.Text = PlayerScore.ToString();
            lblComputerScoreDisplay.Text = ComputerScore.ToString();
            lblRoundNo.Text = "Round " + RoundNo;

            Button[] numberButtons = new Button[] { btnNum1, btnNum2, btnNum3, btnNum4, btnNum5, btnNum6 };

            foreach(Button b in numberButtons)
            {
                b.Text = numbers[i].ToString();
                i++;
            }

            switch (Difficulty)
            {
                case "easy":
                    ea = new EasyAlgorithm(Goal, Numbers.ToList());
                    gca = new GetComputerAnswer(ea.GetComputerAnswer);
                    break;

                case "normal":
                    double Temperature = 1000;
                    a = new Algorithm(Goal, Temperature, Numbers.ToList());
                    gca = new GetComputerAnswer(a.GetComputerAnswer);
                    break;
            }
            

            AiWorker.RunWorkerAsync();        
        }

        private void EndRound()
        {
            

            int pscore = AwardPoints(PlayerResult);
            int cscore = 0;

            try
            {
              cscore   = AwardPoints(ComputerResults.Item3);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Computer failed to submit an answer in time");
            }

            if(pscore > cscore)
            {
                PlayerScore += pscore;
            }
            else if(pscore < cscore)
            {
                ComputerScore += cscore;
            }
            else
            {
                PlayerScore += pscore;
                ComputerScore += cscore;
            }

            //MessageBox.Show("Wait");

            if(RoundNo < 2)
            {
                RoundNo++;
                this.Hide();
                NumberSelection ns = new NumberSelection();
                ns.Show();
            }
            else
            {
                GameOver g;

                if(PlayerScore > ComputerScore)
                {
                    g = new GameOver("player");
                }
                else if(PlayerScore < ComputerScore)
                {
                    g = new GameOver("computer");
                }
                else
                {
                    g = new GameOver("draw");
                }
                g.Show();
                this.Hide();

            }

        }

        private int AwardPoints(int result)
        {
            int closeness = Math.Abs(Goal - result);
            int score = 0;

            if(closeness == 0)
            {
                score = 10;
            }
            else if(closeness < 5 && closeness != 0)
            {
                score = 7;
            }
            else if(closeness > 5 && closeness <= 10)
            {
                score = 5;
            }

            return score;

        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            lblCountdownDisplay.Text = Countdown--.ToString();

            if(Countdown == 0)
            {
                timer.Stop();
                EndRound();
            }
        }

        private HashSet<int> GetNumbers(int largeNums, int smallNums)
        {
            int[] Large = new int[] { 25, 50, 75, 100 };
            Random r = new Random();
            HashSet<int> roundNumbers = new HashSet<int>();

            for (int i = 0; i < largeNums; i++)
            {
                if(i == 0)
                {
                    
                    roundNumbers.Add(Large[r.Next(0, 4)]);
                }
                else
                {
                    while (!roundNumbers.Add(Large[r.Next(0, 4)]));

                }
            }

            for (int  i = 0; i < smallNums; i++)
            {
                while (!roundNumbers.Add(r.Next(1, 10)));
            }
            return roundNumbers;
        }


        public static string PrintSolution(Tuple<int[], string[]> solution)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();

            while (i != solution.Item1.Length)
            {
                sb.Append(solution.Item1[i]);
                if (i != solution.Item2.Length)
                {
                    sb.Append(solution.Item2[i]);
                }
                i++;
            }

            return sb.ToString();
        }

        public static string PrintSolution(int[] operands, string[] operators)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();

            while (i != operands.Length)
            {
                sb.Append(operands[i]);
                if (i != operators.Length)
                {
                    sb.Append(operators[i]);
                }
                i++;
            }

            return sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int i in Numbers)
            {
                sb.Append(i);
                sb.Append(",");
            }

        
            StartRound sr = new StartRound(sb.ToString(), Goal);
            DialogResult d = sr.ShowDialog();

            

            if (d == DialogResult.Yes)
            {
                InitRound();
            }
        }

        private void Form1_Hide()
        {
            this.Hide();
        }

        private void AiWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ComputerResults = gca.Invoke();        
        }

        private void AiWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate { lblComputerResults.Text = String.Format("The Computers solution is: {0}\nIt's value is: {1}", PrintSolution(ComputerResults.Item1, ComputerResults.Item2), ComputerResults.Item3); }));                 
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            NumberPressed(btnNum1);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            NumberPressed(btnNum2);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            NumberPressed(btnNum3);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            NumberPressed(btnNum4);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            NumberPressed(btnNum5);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            NumberPressed(btnNum6);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperatorPressed(btnAdd);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            OperatorPressed(btnSubtract);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OperatorPressed(btnMultiply);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperatorPressed(btnDivide);
        }

        private void NumberPressed(Button btn)
        {
            int btnVal = int.Parse(btn.Text);

            lblPlayerEq.Text += btnVal;
            PlayerOperands.Add(btnVal);
            PlayerEq += " " + btnVal;
            UsedNumbers.Add(btn);

            foreach (Button c in grpNumbers.Controls)
            {
                c.Enabled = false;
            }
            grpOperators.Enabled = true;
            UpdatePlayerAnswer();
            btnOpenBracket.Enabled = false;
        }

        private void OperatorPressed(Button btn)
        {
            string btnVal = btn.Text;
            lblPlayerEq.Text += btnVal;
            PlayerEq += " " + btnVal;
 
            foreach(Button b in grpNumbers.Controls)
            {
                if(!UsedNumbers.Contains(b))
                {
                    b.Enabled = true;
                }
            }

            grpOperators.Enabled = false;
            UpdatePlayerAnswer();

            if(!OpenBracketDisabled)
            {
                btnOpenBracket.Enabled = true;
            }

           
            /*
            if (PlayerOperators.Count > 0 && PlayerOperators[PlayerOperators.Count - 1] == ")")
            {
                string lastoperator = PlayerOperators[PlayerOperators.Count - 1];
                PlayerOperators.RemoveAt(PlayerOperators.Count - 1);

                PlayerOperators.Add(lastoperator + btnVal);
            }
            else
            {
                PlayerOperators.Add(btnVal);
            }*/
        }


        private void UpdatePlayerAnswer()
        {

            PlayerEqCalc pc = new PlayerEqCalc();  
            PlayerResult = pc.ConverttoPostfix(PlayerEq);
            lblPlayerCurrentAnswer.Text = PlayerResult.ToString();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {

            UsedNumbers.RemoveRange(0, UsedNumbers.Count);
            lblPlayerCurrentAnswer.Text = "";
            lblPlayerEq.Text = "";
            PlayerEq = " ";
            
            foreach(Button b in grpNumbers.Controls)
            {
                b.Enabled = true;
            }
            grpNumbers.Enabled = true;
            grpOperators.Enabled = true;
            grpBrackets.Enabled = true;
            btnOpenBracket.Enabled = true;
            OpenBracketDisabled = false;
            lblPlayerResults.Text = " ";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblPlayerResults.Text = String.Format("The Players Solution is: {0}\nIt's value is: {1}", PlayerEq, PlayerResult);
            grpNumbers.Enabled = false;
            grpBrackets.Enabled = false;
            grpOperators.Enabled = false;

        }

     

        private void btnOpenBracket_Click(object sender, EventArgs e)
        {
            btnOpenBracket.Enabled = false;
            btnCloseBracket.Enabled = true;
            OpenBracketDisabled = true;
            PlayerEq += " " + btnOpenBracket.Text;
            if (PlayerOperators.Count > 0)
            {
                string lastoperator = PlayerOperators[PlayerOperators.Count - 1];
                PlayerOperators.RemoveAt(PlayerOperators.Count - 1);

                PlayerOperators.Add(lastoperator + btnOpenBracket.Text);               
            }
            else
            {
                PlayerOperators.Add(btnOpenBracket.Text);
            }
            lblPlayerEq.Text += btnOpenBracket.Text;
            UpdatePlayerAnswer();
        }

        private void btnCloseBracket_Click(object sender, EventArgs e)
        {
            btnCloseBracket.Enabled = false;
            btnOpenBracket.Enabled = true;
            OpenBracketDisabled = false;
            PlayerEq += " " + btnCloseBracket.Text;
            PlayerOperators.Add(btnCloseBracket.Text);
            lblPlayerEq.Text += btnCloseBracket.Text;
            UpdatePlayerAnswer();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult d = MessageBox.Show("Are you sure you wish to exit?", "exit", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }  
    }
}

/* public string CreateTokenString(int[] operands, string[] operators)
      {
          int i = 0;
          StringBuilder sb = new StringBuilder();

          while (i != operands.Length)
          {
              sb.Append(" ");
              sb.Append(operands[i]);
              if (i != operators.Length)
              {
                  if (operators[i].Contains("("))
                  {
                      string[] ops = operators[i].Split('(');
                      sb.Append(" ");
                      sb.Append(ops[0]);
                      sb.Append(" ");
                      sb.Append("(");
                  }
                  else if (operators[i].Contains(")"))
                  {
                      string[] ops = operators[i].Split(')');

                      sb.Append(" ");
                      sb.Append(")");
                      sb.Append(" ");
                      sb.Append(ops[1]);
                  }
                  else
                  {
                      sb.Append(" ");
                      sb.Append(operators[i]);
                  }
              }
              i++;
          }
          return sb.ToString();
      }*/
