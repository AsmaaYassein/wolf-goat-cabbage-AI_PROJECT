using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wolf.Goast.Cabbage
{
    public partial class Form1 : Form
    {
        public int score;

        private WGC_Node root;

        private string currentItemOnBoat = "";

        private bool goatOnBoat = false;
        private bool wolfOnBoat = false;
        private bool cabbageOnBoat = false;


        private int goatCount = 0;
        private int wolfCount = 0;
        private int cabbageCount = 0;

        
        //private bool wolfOnLeft = false;
        //private bool goatOnLeft = false;
        //private bool cabbageOnLeft = false;
        //private bool boatOnLeft = true;


        public Form1()
        {
            InitializeComponent();
            root = new WGC_Node();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void reset(object sender, EventArgs e)
        {
            this.goat.Location = new System.Drawing.Point(550, 400);
            this.wolf.Location = new System.Drawing.Point(510, 360);
            this.cabbbage.Location = new System.Drawing.Point(460, 360);
            this.boat.Location = new System.Drawing.Point(315, 360);

            goatCount = 0;
            wolfCount = 0;
            cabbageCount = 0;

            //wolfOnLeft = false;
            //goatOnLeft = false;
            //cabbageOnLeft = false;
            //boatOnLeft = true;
            wolfOnBoat = false;
            goatOnBoat = false;
            cabbageOnBoat = false;

            wolf.Visible = true;
            goat.Visible = true;
            cabbbage.Visible = true;

        }
       /* private void CheckCabbageDisappearance()
        {
            if (goatOnLeft == cabbageOnLeft && !wolfOnLeft && !wolfOnBoat)
            {
                // If the cabbage is alone with the goat, make the cabbage disappear
                cabbbage.Visible = false;
                cabbageOnBoat = false;
                cabbageOnLeft = false; // Assuming the cabbage disappears from both sides
                // You might need additional logic if cabbage can appear elsewhere
            }
        }*/



        private void moveback(object sender, EventArgs e)
        {
            currentItemOnBoat = "";


            if (goat.Location == new System.Drawing.Point(200, 445))
            {

                //for (int i = 200; i <= 470; i++)
                // {
                this.boat.Location = new System.Drawing.Point(470, 421);
                this.goat.Location = new System.Drawing.Point(560, 440);
                score++;
                // }
            }


            if (cabbbage.Location == new System.Drawing.Point(150, 440))
            {

                //for (int a = 150; a <= 490; a++)
                //{
                this.boat.Location = new System.Drawing.Point(490, 421);
                this.cabbbage.Location = new System.Drawing.Point(490, 440);
                score++;
                //}
            }


            if (wolf.Location == new System.Drawing.Point(90, 445))
            {

                // for (int j = 90; j <= 450; j++)
                // {
                this.boat.Location = new System.Drawing.Point(450, 421);
                this.wolf.Location = new System.Drawing.Point(450, 445);
                score++;
                //}
            }

        }




        private void move_button(object sender, EventArgs e)
        {
            
            int totalItemsOnBoat = goatCount + wolfCount + cabbageCount;
           
            if (totalItemsOnBoat > 1)
            {
                // Reset game here
                this.reset(null, null);
                totalItemsOnBoat = goatCount + wolfCount + cabbageCount;
                            return;
            }



            if (goat.Location == new System.Drawing.Point(430, 390))
            {

                //for (int i = 440; i >= 200; i--)
                //{
                this.boat.Location = new System.Drawing.Point(200, 421);
                this.goat.Location = new System.Drawing.Point(200, 445);
                score++;
                //}
            }


            if (cabbbage.Location == new System.Drawing.Point(380, 390))
            {

                //for (int a = 440; a >= 150; a--)
                // {
                this.boat.Location = new System.Drawing.Point(150, 421);
                this.cabbbage.Location = new System.Drawing.Point(150, 440);
                score++;
                //}
            }


            if (wolf.Location == new System.Drawing.Point(350, 390))
            {

                //for (int j = 440; j >= 90; j--)
                //{
                this.boat.Location = new System.Drawing.Point(90, 421);
                this.wolf.Location = new System.Drawing.Point(90, 445);
                score++;
                //}
            }


            currentItemOnBoat = "";


        }

        private void down_click(object sender, EventArgs e)
        {
            currentItemOnBoat = "";

            if (goat.Location == new System.Drawing.Point(200, 445))
            {

                this.goat.Location = new System.Drawing.Point(200, 380);
            }
            else
            {

                this.goat.Location = new System.Drawing.Point(550, 400);
            }


            if (wolf.Location == new System.Drawing.Point(90, 445))
            {

                this.wolf.Location = new System.Drawing.Point(90, 390);
            }
            else
            {
                this.wolf.Location = new System.Drawing.Point(510, 360);
            }


            if (cabbbage.Location == new System.Drawing.Point(150, 440))
            {

                this.cabbbage.Location = new System.Drawing.Point(150, 390);
            }
            else
            {

                this.cabbbage.Location = new System.Drawing.Point(460, 360);
            }
        }


        private void boat_Click(object sender, EventArgs e)
        {
            if (boat.Location == new System.Drawing.Point(90, 421))
            {
               

                this.boat.Location = new System.Drawing.Point(315, 360);
            }
            else
            {
                this.boat.Location = new System.Drawing.Point(90, 421);

            }
           

             
               score++;
        }

        private void goat_Click(object sender, EventArgs e)
        {

            /*// If the goat is on the boat, move it to the opposite side
            if (goatOnBoat)
            {
                goatOnBoat = false;
                goatOnLeft = !goatOnLeft;
            }
            else
            {
                // Check if the goat is alone with the cabbage
                if ((goatOnLeft && !wolfOnLeft && cabbageOnLeft) || (!goatOnLeft && wolfOnLeft && !cabbageOnLeft))
                {
                    // Goat eats the cabbage if they are alone together
                    cabbbage.Visible = false;
                    cabbageOnBoat = false;
                    cabbageOnLeft = !goatOnLeft;
                }
                else
                {
                    // If the goat is not alone with the cabbage, move it to the boat
                    goatOnBoat = true;
                }
            }*/

            if (currentItemOnBoat != "")
            {
                MessageBox.Show("The boat is already carrying an item. Move the boat first before adding another item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            goatCount++;
            currentItemOnBoat = "goat";
            goatOnBoat = true;



            if (goat.Location == new System.Drawing.Point(200, 380))
            {

                this.goat.Location = new System.Drawing.Point(200, 445);
            }

            else
            {

                this.goat.Location = new System.Drawing.Point(430, 390);
            }
        }



        private void wolf_click(object sender, EventArgs e)
        {

           /* // If the wolf is on the boat, move it to the opposite side
            if (wolfOnBoat)
            {
                wolfOnBoat = false;
                wolfOnLeft = !wolfOnLeft;
            }
            else
            {
                // Check if the wolf is alone with the goat
                if ((wolfOnLeft && goatOnLeft && !cabbageOnLeft) || (!wolfOnLeft && !goatOnLeft && cabbageOnLeft))
                {
                    // Wolf eats the goat if they are alone together
                    goat.Visible = false;
                    goatOnBoat = false;
                    goatOnLeft = !wolfOnLeft;
                }
                else
                {
                    // If the wolf is not alone with the goat, move it to the boat
                    wolfOnBoat = true;
                }
            }*/


            if (currentItemOnBoat != "")
            {
                MessageBox.Show("The boat is already carrying an item. Move the boat first before adding another item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            wolfCount++;
            currentItemOnBoat = "wolf";
            wolfOnBoat = true;




            if (wolf.Location == new System.Drawing.Point(90, 390))
            {

                this.wolf.Location = new System.Drawing.Point(90, 445);
            }
            else
            {
                this.wolf.Location = new System.Drawing.Point(350, 390);
            }



        }

        private void cabbage_Click(object sender, EventArgs e)
        {

            // If the cabbage is on the boat, move it to the opposite side
           /* if (cabbageOnBoat)
            {
                cabbageOnBoat = false;
                cabbageOnLeft = !cabbageOnLeft;
            }
            else
            {
                // If the cabbage is not on the boat, move it to the boat
                cabbageOnBoat = true;
            }*/

            if (currentItemOnBoat != "")
            {
                MessageBox.Show("The boat is already carrying an item. Move the boat first before adding another item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            cabbageCount++;
            currentItemOnBoat = "cabbage";
            cabbageOnBoat = true;


            if (cabbbage.Location == new System.Drawing.Point(150, 390))
            {

                this.cabbbage.Location = new System.Drawing.Point(150, 440);
            }
            else
            {

                this.cabbbage.Location = new System.Drawing.Point(380, 390);
            }

        }
        private int CountItemsOnBoat()
          {
            int itemCount = 0;

            // Check each item and increment the count if it's on the boat
            if (goatOnBoat) itemCount++;
            if (wolfOnBoat) itemCount++;
            if (cabbageOnBoat) itemCount++;

            return itemCount;
        }

        //**************************************************************************
        private void button3_Click_1(object sender, EventArgs e)
        {
            List<WGC_Node> solutionDFS = fsolution.FindSolution(root, useBFS: true);
            DisplaySolution(solutionDFS, "BFS");
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            List<WGC_Node> solutionDFS = fsolution.FindSolution(root, useBFS: false);
            DisplaySolution(solutionDFS, "DFS");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            button5.Text = "Score = " + score.ToString();
        }

        private void DisplaySolution(List<WGC_Node> solution, string searchAlgorithm)
        {
            if (solution != null)
            {
                StringBuilder resultBuilder = new StringBuilder();
                foreach (var node in solution)
                {
                    string eastSide = "[" + string.Join(", ", node.East) + "]";
                    string westSide = "[" + string.Join(", ", node.West) + "]";
                    string boatPosition = "[" + (node.BoatSide ? "Left" : "Right") + "]";

                    resultBuilder.AppendLine(eastSide + " " + westSide + " " + boatPosition);
                }

                
                MessageBox.Show($"{searchAlgorithm} Solution: {Environment.NewLine}{resultBuilder.ToString()}", "Solution Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                MessageBox.Show("No solution found!", "Solution Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class WGC_Node
        {
            private static List<List<string>> incompatibilities = new List<List<string>>()
            {
                new List<string>() {"c", "g", "w"},
                new List<string>() {"g", "w"},
                new List<string>() {"c", "g"}
            };

            public List<string> West { get; set; }
            public List<string> East { get; set; }
            public bool BoatSide { get; set; }
            public List<WGC_Node> Children { get; set; }


            //initial state(constructor)
            public WGC_Node(List<string> west = null, List<string> east = null, bool boatSide = false, List<WGC_Node> children = null)
            {
                West = west ?? new List<string>() { "w", "c", "g" };
                East = east ?? new List<string>();
                BoatSide = boatSide;
                Children = children ?? new List<WGC_Node>();
            }

            public override string ToString()
            {
                return string.Join(", ", West) + string.Join(", ", East) + (BoatSide ? "Left" : "Right");
            }

            public void GenerateChildren(List<WGC_Node> previousStates, Dictionary<WGC_Node, WGC_Node> parentMap)
            {
                List<WGC_Node> children = new List<WGC_Node>();

                if (!BoatSide)
                {
                    foreach (var item in West)
                    {
                        List<string> newWest = West.Except(new List<string>() { item }).ToList();
                        List<string> newEast = East.Concat(new List<string>() { item }).ToList();
                        if (!incompatibilities.Any(x => x.All(newWest.Contains)) && !StateInPrevious(previousStates, newWest, newEast, !BoatSide))
                        {
                            var child = new WGC_Node(newWest, newEast, !BoatSide);
                            children.Add(child);
                            parentMap[child] = this;
                        }
                    }

                    if (!incompatibilities.Any(x => x.All(West.Contains)) && !StateInPrevious(previousStates, West, East, !BoatSide))
                    {
                        var child = new WGC_Node(West, East, !BoatSide);
                        children.Add(child);
                        parentMap[child] = this;
                    }
                }
                else
                {
                    foreach (var item in East)
                    {
                        List<string> newWest = West.Concat(new List<string>() { item }).ToList();
                        List<string> newEast = East.Except(new List<string>() { item }).ToList();
                        if (!incompatibilities.Any(x => x.All(newEast.Contains)) && !StateInPrevious(previousStates, newWest, newEast, !BoatSide))
                        {
                            var child = new WGC_Node(newWest, newEast, !BoatSide);
                            children.Add(child);
                            parentMap[child] = this;
                        }
                    }

                    if (!incompatibilities.Any(x => x.All(East.Contains)) && !StateInPrevious(previousStates, West, East, !BoatSide))
                    {
                        var child = new WGC_Node(West, East, !BoatSide);
                        children.Add(child);
                        parentMap[child] = this; 
                    }
                }

                Children = children;
            }

            private bool StateInPrevious(List<WGC_Node> previousStates, List<string> west, List<string> east, bool boatSide)
            {
                return previousStates.Any(state => state.West.SequenceEqual(west) && state.East.SequenceEqual(east) && state.BoatSide == boatSide);
            }
        }

        class fsolution
        {
            public static List<WGC_Node> FindSolution(WGC_Node rootNode, bool useBFS = true)
            {
                var toVisit = new List<WGC_Node>() { rootNode };
                var previousStates = new List<WGC_Node>();
                var parentMap = new Dictionary<WGC_Node, WGC_Node>();

                while (toVisit.Any())
                {
                    var node = useBFS ? toVisit.First() : toVisit.Last();
                    toVisit.Remove(node);

                    if (!StateInPrevious(previousStates, node.West, node.East, node.BoatSide))
                    {
                        previousStates.Add(node);
                    }

                    node.GenerateChildren(previousStates, parentMap);

                    
                    toVisit.AddRange(node.Children);

                   
                    if (node.East.Count == 3)
                    {
                        var solution = new List<WGC_Node>();
                        while (node != null)
                        {
                            solution.Insert(0, node);
                            node = parentMap.ContainsKey(node) ? parentMap[node] : null; 
                        }
                        return solution;
                    }
                }

                return null;
            }

            static bool StateInPrevious(List<WGC_Node> previousStates, List<string> west, List<string> east, bool boatSide)
            {
                return previousStates.Any(state => state.West.SequenceEqual(west) && state.East.SequenceEqual(east) && state.BoatSide == boatSide);
            }
        }

    }
}

       
        
    

