using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ListGen
{
    class Puzzle
    {
        public int number;
        public string title;
        public string author;

        public string rubric;

        public Grid grid;
        public List<Clue> clues;

        public Puzzle()
        {
            //Template ();

            //Listener3827 ();
            //Listener4399 ();
            //Listener4451 ();
            //Listener4516 ();
            //Listener4529 ();
            //Listener4425 ();
            Listener4503 ();
        }

        public override string ToString()
        {
            return $" No {number} | {title} | by {author}";
        }

        public string GetRubric()
        {
            return rubric;
        }

        public void DrawGrid(Graphics g)
        {
            grid.DrawGrid (g);
        }

        public void DrawAcrossClues(Graphics g)
        {
            grid.DrawClues (g, clues, ClueDirection.ac);
        }
        public void DrawDownClues(Graphics g)
        {
            grid.DrawClues (g, clues, ClueDirection.dn);
        }

        public void DrawRubric(Graphics g)
        {
            using (var drawFont = new Font ("Arial", 10))
            using (var drawBrush = new SolidBrush (Color.Black))
            {
                g.DrawString (rubric, drawFont, drawBrush, 5, 5);//drawFormat);
            }
        }

        private void Template()
        {
            number = 0;
            title = "title";
            author = "author";
            rubric = "rubric";
            grid = new Grid (height: 1, width: 1);
            clues = new List<Clue>
            {
                new Clue ( 0, 0, "1", 1, "clue", ClueDirection.ac),

                new Clue ( 0, 0, "1", 1, "clue", ClueDirection.dn)
            };

            grid.AddClues (clues);
        }

        private void Listener4503()
        {
            number = 4503;
            title = "Property Management";
            author = "Smudge";
            rubric = "Each grid entry must be associated with exactly one of the properties listed below, which describes\n"+
                "both the entry's grid number and the value to be entered. Where across and down entries have the\n" +
                "same grid number, the associated property is different for each. Numbers in brackets indicate how\n" +
                "many entries are to be associated with each property. No entry starts with a zero and where the\n" +
                "reverse of a number is referred to, the number has at least two difits and neither it nor its reverse\n" +
                "starts with a zero. Every entry is greater than the grid number. In property descriptions, \"number\"\n" +
                "and the symbol 'n' always mean an integer greater than zero, unless otherwise stated.\n" +
                "   The following information may be helpful. For any number that is divisible by its reverse, the\n" +
                "result of the division is 1, 4 or 9. Every even perfect number is an nth triangular number, where n is\n" +
                "a Mersenne prime; there are currently no known odd perfect numbers. Every integer greater than 1\n" +
                "is the sum of two non-zero squares (not necessarily different) unless a prime that is one less than a\n" +
                "multiple of four occurs an odd number of times in the number's prime factorisatoin; for example,\n" +
                "270 = 2*3*3*3*5 is not the sum of two squares (it has an odd number of 3s), nor is the prime 103\n" +
                "(because 104 is a multiple of 4)";
            grid = new Grid (height: 1, width: 1);
            clues = new List<Clue>
            {
                new Clue ( 0, 0, "1", 1, "clue", ClueDirection.ac),

                new Clue ( 0, 0, "1", 1, "clue", ClueDirection.dn)
            };

            grid.AddClues (clues);
        }

        private void Listener3827()
        {
            number = 3827;
            title = "The Latin Squire";
            author = "Arden";
            rubric = 
                "The Squire of the title aspires to knighthood and must demonstrate that he is worthy by\n" +
                "performing a knight's tour of the grid. Starting on one of the grid squares, he makes\n" +
                "63 knight's moves to visit each square exactly once. The completed grid is a Latin square,\n" +
                "with each of the digits 0 to 7 occurring once in each row and once in each column.\n" +
                "The Squire must begin his tour on a 0 before jumping to a 1, then a 2, then a 3, etc; on\n" +
                "reaching a 7 he must jump to a new 0 and begin again.\n" +
                "     The Rules of chivalry state that the tour must finish on one of the four central grid\n" +
                "squares. But, as he is struggling to devise a route, solvers must help the Squire by\n" +
                "highlighting his starting point.\n" +
                "     Letters in the clues represent the integers 1 to 26 in an order to be determined.\n" +
                "All letters are different and there are no leading zeros. / means \"divided by\"";
            grid = new Grid (height: 8, width: 8);
            clues = new List<Clue>
            {
                new Clue( 0, 0, "1", 4, "WHY", ClueDirection.ac),
                new Clue( 0, 4, "4", 4, "ZEAL - OTS"),
                new Clue( 1, 1, "7", 3, "BOX"),
                new Clue( 1, 5, "8", 3, "EPEES"),
                new Clue( 2, 0, "10", 2, "QU + AD"),
                new Clue( 2, 2, "11", 5, "SL + EETINESS"),
                new Clue( 3, 1, "14", 4, "JAY"),
                new Clue( 3, 6, "15", 2, "OO"),
                new Clue( 4, 0, "17", 2, "TWEE"),
                new Clue( 4, 3, "18", 4, "E + GGED"),
                new Clue( 5, 1, "20", 5, "LEO + TALKS"),
                new Clue( 5, 6, "21", 2, "SNEE + ZE"),
                new Clue( 6, 0, "23", 3, "G + UM"),
                new Clue( 6, 4, "25", 3, "SO + VIET"),
                new Clue( 7, 0, "26", 4, "DI + SCS"),
                new Clue( 7, 4, "27", 4, "BL + ACKEN"),

                new Clue( 0, 0, "1", 3, "SENSE", ClueDirection.dn),
                new Clue( 0, 1, "2", 5, "RENO + VATION"),
                new Clue( 0, 2, "3", 6, "OLD + GROUPS"),
                new Clue( 0, 4, "4", 4, "COST"),
                new Clue( 0, 5, "5", 2, "L + ENTEN"),
                new Clue( 0, 7, "6", 3, "LOT"),
                new Clue( 1, 6, "9", 2, "JI - BS"),
                new Clue( 2, 5, "12", 6, "PIQUANT + ALE"),
                new Clue( 3, 0, "13", 2, "YEN"),
                new Clue( 3, 6, "15", 5, "INFEF + T"),
                new Clue( 3, 7, "16", 2, "ANTENN / A"),
                new Clue( 4, 3, "18", 4, "HOM + E"),
                new Clue( 5, 0, "19", 3, "PIECE - MEAL"),
                new Clue( 5, 1, "20", 2, "SETTEE"),
                new Clue( 5, 7, "22", 3, "TAK - E"),
                new Clue( 6, 2, "24", 2, "IT")
            };

            grid.AddClues (clues);
        }

        private void Listener4425()
        {
            number = 4425;
            title = "Clue-by-four";
            author = "gwizardry";
            rubric =
                "Lagrange's";
            grid = new Grid (height: 8, width: 8);
            clues = new List<Clue>
            {
                new Clue ( 0, 0, "1", 2, "G G D D", ClueDirection.ac),
                new Clue ( 0, 2, "3", 3, "N N D D"),
                new Clue ( 0, 5, "5", 3, "Z X D D"),
                new Clue ( 1, 0, "8", 3, "R T T D"),
                
                new Clue ( 0, 1, "2", 8, "G X D D", ClueDirection.dn),
                new Clue ( 0, 2, "3", 8, "J J D D"),
                new Clue ( 0, 4, "4", 8, "C P D D"),
                new Clue ( 0, 5, "5", 8, "Z J T T"),
                new Clue ( 0, 6, "6", 8, "C J X D"),
                new Clue ( 0, 7, "7", 8, "K P X D"),
                new Clue ( 1, 0, "8", 7, "G T D D" ),
            };

            grid.AddClues (clues);
        }

        private void Listener4529()
        {
            number = 4529;
            title = "St Hubert's College";
            author = "Oyler";
            rubric =
                "St Hubert's College  was founded in the 17th Century and has an impressive Great Quad, a square\n" +
                "whose side length in yards is exactly divisible by its number of factors. There is a Lesser Quad\n" +
                "which is rectangular with one of its side lengths (in yards) being a factor of the Great Quad's length.\n" +
                "In its Time Travel department, Oyler discovered the following puzzle, but which year it came from\n" +
                "is unknown. It was written by the Master of the college as a secret way to remember the security\n" +
                "code for his wife's bank account, which must be written below the grid.\n" +
                "\n" +
                "\"My wife and I will celebrate our silver wedding anniversary next year. Her bank security code is \n" +
                "the four-digit product of three distinct two-digit prime numbers, two of which are her age now and \n" +
                "her age when we got married. No entry starts with a zero and all are different.\"";

            grid = new Grid (height: 8, width: 8);
            clues = new List<Clue>
            {
                new Clue ( 0, 0, "1", 2, "The number of college graduates nominated for Nobel prizes in the 20th century, a factor of 14dn", ClueDirection.ac),
                new Clue ( 0, 3, "2", 2, "The number of children my wife has mothered both in and out of wedlock, a factor of 14dn"),
                new Clue ( 0, 6, "3", 2, "clue"),
                new Clue ( 1, 2, "5", 2, "clue"),
                new Clue ( 1, 5, "6", 3, "clue"),
                new Clue ( 2, 0, "7", 5, "clue"),
                new Clue ( 2, 6, "9", 2, "clue"),
                new Clue ( 3, 4, "10", 3, "clue"),
                new Clue ( 4, 1, "12", 3, "clue"),
                new Clue ( 5, 0, "15", 2, "clue"),
                new Clue ( 5, 3, "16", 5, "clue"),
                new Clue ( 6, 0, "18", 3, "clue"),
                new Clue ( 6, 4, "19", 2, "clue"),
                new Clue ( 7, 0, "20", 2, "clue"),
                new Clue ( 7, 3, "21", 2, "clue"),
                new Clue ( 7, 6, "22", 2, "clue"),


                new Clue ( 0, 0, "1", 4, "clue", ClueDirection.dn),
                new Clue ( 0, 3, "2", 3, "clue"),
                new Clue ( 0, 6, "3", 4, "clue"),
                new Clue ( 0, 7, "4", 3, "clue"),
                new Clue ( 1, 2, "5", 4, "clue"),
                new Clue ( 2, 4, "8", 2, "clue"),
                new Clue ( 3, 5, "11", 4, "clue"),
                new Clue ( 4, 1, "12", 4, "clue"),
                new Clue ( 4, 3, "13", 2, "clue"),
                new Clue ( 4, 7, "14", 4, "clue"),
                new Clue ( 5, 0, "15", 3, "clue"),
                new Clue ( 5, 4, "17", 3, "clue")
            };

            grid.AddClues (clues);
        }

        private void Listener4399()
        {
            number = 4399;
            title = "Square Time Sums";
            author = "Oyler";
            rubric =
                "The letter variables used in the clues form four triples (A, B, C), (J, K, L), (P, Q, R) and (X, Y, Z).\n" +
                "where each triple consists of square numbers of two, three and four digits respectively, that between\n" +
                "them contain all the digits from 1 to 9 inclusive. After filling the grid, solvers must identify and\n" +
                "highlight two complete rows and two complete columns that are related to the theme. No entry\n" +
                "starts with zero and all are different.";

            // --- Create a grid
            grid = new Grid (height: 9, width: 9);

            // --- Add some clues
            clues = new List<Clue>
                {
                    // --- ACROSS

                    new Clue( 0, 0, "1", 2, "J", ClueDirection.ac),
                    new Clue( 0, 2, "3", 2, "6ac + 7dn"),
                    new Clue( 0, 5, "6", 2, "17ac - B"),
                    new Clue( 0, 7, "8", 2, "Multiple of 42dn"),

                    new Clue( 1, 0, "9", 3, "K"),
                    new Clue( 1, 4, "11", 2, "P"),
                    new Clue( 1, 6, "13", 3, "Multiple of(44dn - J)"),

                    new Clue( 2, 0, "15", 4, "L"),
                    new Clue( 2, 4, "16", 2, "P - A"),
                    new Clue( 2, 6, "17", 3, "Multiple of 5dn"),

                    new Clue( 3, 0, "18", 2, "A - X"),
                    new Clue( 3, 2, "20", 3, "7 x A"),
                    new Clue( 3, 5, "22", 2, "Factor of Q"),
                    new Clue( 3, 7, "23", 2, "Prime"),

                    new Clue( 4, 1, "25", 3, "Q"),
                    new Clue( 4, 5, "27", 3, "8 x P + 10 x X"),

                    new Clue( 5, 0, "29", 2, "X"),
                    new Clue( 5, 2, "31", 2, "Factor of C"),
                    new Clue( 5, 4, "33", 3, "27dn + 28dn"),
                    new Clue( 5, 7, "35", 2, "Factor of 36ac"),

                    new Clue( 6, 0, "36", 3, "Multiple of 35ac"),
                    new Clue( 6, 3, "37", 2, "P - 7dn"),
                    new Clue( 6, 5, "38", 4, "Multiple of (2 x A + 2 x J + 3 * X)"),

                    new Clue( 7, 0, "41", 3, "Prime"),
                    new Clue( 7, 3, "43", 2, "Prime"),
                    new Clue( 7, 6, "45", 3, "Y - 37ac"),

                    new Clue( 8, 0, "46", 2, "Reverse of 31ac"),
                    new Clue( 8, 2, "47", 2, "Factor of 16dn"),
                    new Clue( 8, 5, "48", 2, "Multiple of 37ac"),
                    new Clue( 8, 7, "49", 2, "A"),

                    // --- DOWN

                    new Clue( 0, 0, "1", 3, "7 x X", ClueDirection.dn),
                    new Clue( 0, 1, "2", 3, "Prime"),
                    new Clue( 0, 3, "4", 3, "K + P - A"),
                    new Clue( 0, 4, "5", 2, "Factor of C"),
                    new Clue( 0, 6, "7", 2, "P - 37ac"),
                    new Clue( 0, 7, "8", 4, "Z"),

                    new Clue( 1, 2, "10", 3, "33ac + 38dn"),
                    new Clue( 1, 5, "12", 3, "B - Q"),
                    new Clue( 1, 8, "14", 4, "B + Q - 22ac"),

                    new Clue( 2, 4, "16", 5, "2 x (C + L + R + Z)"),
                    new Clue( 2, 6, "17", 3, "B"),

                    new Clue( 3, 1, "19", 2, "Factor of 45ac"),
                    new Clue( 3, 3, "21", 2, "48ac - A"),

                    new Clue( 4, 0, "24", 4, "R"),
                    new Clue( 4, 2, "26", 3, "17ac - 31ac"),
                    new Clue( 4, 5, "27", 2, "33ac - 28dn"),
                    new Clue( 4, 7, "28", 2, "33ac - 27dn"),

                    new Clue( 5, 1, "30", 4, "C"),
                    new Clue( 5, 3, "32", 3, "Y"),
                    new Clue( 5, 6, "34", 3, "Prime"),

                    new Clue( 6, 5, "38", 3, "10dn - 33ac"),
                    new Clue( 6, 7, "39", 3, "Multiple of 43ac"),
                    new Clue( 6, 8, "40", 3, "19dn + Y"),

                    new Clue( 7, 2, "42", 2, "Prime"),
                    new Clue( 7, 4, "44", 2, "5 x 19dn")
                };

            // --- Put the clues on the grid
            grid.AddClues (clues);
        }

        private void Listener4451()
        {
            number = 4451;
            title = "Numerical Playfair";
            author = "Zag";
            rubric =
                "All 2-digit clue answers have non-zero, non-repeating digits and must be enciphered using a\n" +
                "Playfair code-square (to be deduced) before entry in the grid. No answer starts with a zero and\n" +
                "all entries are distinct";

            // --- Create a grid
            grid = new Grid (height: 4, width: 5);

            // --- Add some clues
            clues = new List<Clue>
            {
                new Clue( 0, 0, "1", 2, "Sum of all 20 digits in the grid", ClueDirection.ac),
                new Clue( 0, 2, "2", 3, "Multiple of another grid entry"),
                new Clue( 1, 0, "4", 3, "One row of the Playfair code-square"),
                new Clue( 2, 2, "7", 3, "Divisor of 3dn"),
                new Clue( 3, 0, "8", 3, "One column of the Playfair code-square"),
                new Clue( 3, 3, "9", 2, "The Playfair code-number for this puzzle"),

                new Clue( 0, 0, "1", 3, "A square minus the grid entry at 1ac", ClueDirection.dn),
                new Clue( 0, 2, "2", 2, "Sum of the digits of 7ac"),
                new Clue( 0, 3, "3", 3, "Reverse of 2ac"),
                new Clue( 1, 1, "5", 3, "Amagram of 6dn"),
                new Clue( 1, 4, "6", 3, "Square"),
                new Clue( 2, 2, "7", 2, "Prime")
            };

            // --- Put the clues on the grid
            grid.AddClues (clues);
        }

        private void Listener4516()
        {
            number = 4516;
            title = "A Defter Premier";
            author = "Arden";
            rubric =
                "Each grid entry is the sum of the squares of two different positive integers, and the clue is either\n" +
                "the sum or the product of these two integers. All entries are distinct and there are no leading\n" +
                "zeros. The entries all share a common feature, which must be identified to resolve ambiguities in\n" +
                "filling the grid. Finders must then find two symetrically placed 9-digit numbers that also share\n" +
                "this feature, and highlight the two pairs of positive integers (also symetrically placed) whose\n" +
                "squares add up to these 9-digit numbers.";

            // --- Create a grid
            grid = new Grid (height: 9, width: 9);

            // --- Add some clues
            clues = new List<Clue>
                {
                    // --- ACROSS

                    new Clue( 0, 0, "1", 3, "150", ClueDirection.ac),
                    new Clue( 0, 3, "3", 3, "220"),
                    new Clue( 0, 7, "6", 2, "7"),
                    new Clue( 1, 4, "9", 5, "23994"),
                    new Clue( 2, 0, "10", 5, "137"),
                    new Clue( 2, 5, "11", 4, "57"),
                    new Clue( 3, 0, "13", 5, "32984"),
                    new Clue( 3, 5, "15", 3, "15"),
                    new Clue( 4, 0, "16", 3, "15"),
                    new Clue( 4, 6, "18", 3, "39"),
                    new Clue( 5, 1, "20", 3, "39"),
                    new Clue( 5, 4, "22", 5, "31746"),
                    new Clue( 6, 0, "25", 4, "1410"),
                    new Clue( 6, 4, "26", 5, "9044"),
                    new Clue( 7, 0, "27", 5, "10726"),
                    new Clue( 8, 0, "29", 2, "11"),
                    new Clue( 8, 3, "30", 3, "90"),
                    new Clue( 8, 6, "31", 3, "144"),



                    new Clue( 0, 0, "1", 4, "1596", ClueDirection.dn),
                    new Clue( 0, 2, "2", 2, "4"),
                    new Clue( 0, 3, "3", 4, "1190"),
                    new Clue( 0, 5, "4", 5, "145"),
                    new Clue( 0, 6, "5", 4, "306"),
                    new Clue( 0, 8, "7", 2, "13"),
                    new Clue( 1, 1, "8", 4, "35"),
                    new Clue( 1, 4, "9", 2, "13"),
                    new Clue( 2, 8, "12", 3, "290"),
                    new Clue( 3, 4, "14", 3, "27"),
                    new Clue( 4, 0, "16", 3, "19"),
                    new Clue( 4, 3, "17", 5, "22374"),
                    new Clue( 4, 7, "19", 4, "65"),
                    new Clue( 5, 2, "21", 4, "924"),
                    new Clue( 5, 5, "23", 4, "97"),
                    new Clue( 5, 8, "24", 4, "2754"),
                    new Clue( 6, 4, "26", 2, "5"),
                    new Clue( 7, 0, "27", 2, "6"),
                    new Clue( 7, 6, "28", 2, "9")
            };

            // --- Put the clues on the grid
            grid.AddClues (clues);
        }
    }
}
