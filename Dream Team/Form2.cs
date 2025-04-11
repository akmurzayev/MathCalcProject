using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Team
{
    public partial class Form2 : Form
    {
        // Creates a Random object to generate random numbers.
        Random rnd = new Random();

        // Holds the current score.
        int score = 0;

        // Holds the total of all scores saved in the list box.
        int total = 0;

        // Variables used for the randomly generated numbers and the correct answer.
        int a, b, correctAnswer;

        // Holds the arithmetic operation symbol ("+" or "-").
        string operation;

        // Timer object to manage the score incrementing at specific intervals.
        System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();

        public Form2()
        {
            InitializeComponent();

            // Set the timer interval to 500 ms (half a second).
            gameTimer.Interval = 500;

            // Link the timer Tick event to the method that handles it.
            gameTimer.Tick += gameTimer_Tick;

            // Display the initial score (0) on the label6.
            label6.Text = score.ToString();

            // Display the initial total (0) on label8.
            label8.Text = total.ToString();
        }

        // This event fires every time the timer "ticks" (in this case, every 500 ms).
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Generate a random increment between 2 and 5 (Next(2, 6) returns 2,3,4,5).
            int randomIncrement = rnd.Next(2, 6);

            // Increase the score by that random amount.
            score += randomIncrement;
            // Update the label6 to show the new score.
            label6.Text = score.ToString();

            // If score reaches 1000 or more, stop the timer and show a message.
            if (score >= 1000)
            {
                gameTimer.Stop();
                MessageBox.Show("Score reached 1000! Game Over!");
            }
        }

        // This method is empty because label3 might be a label that does nothing when clicked.
        private void label3_Click(object sender, EventArgs e)
        {

        }

        // This event occurs when Form2 is loaded.
        private void Form2_Load(object sender, EventArgs e)
        {
            // Generate the first random question (initializing a, b, and correctAnswer).
            GenerateRandomQuestions();

            // Hide the second button (Stop button) at the start.
            button2.Visible = false;
        }

        // This event is triggered when the first button is clicked (the "Start" button initially).
        private void button1_Click(object sender, EventArgs e)
        {
            // Start the timer.
            gameTimer.Start();

            // Change the button1 text from "Start" to "Stop".
            button1.Text = "Stop";

            // Hide button2 (making sure only button1 is visible for controlling start/stop).
            button2.Visible = false;

            // Remove the button1_Click event handler from button1 and replace it with button2_Click.
            // This effectively turns button1 into the "Stop" button once clicked again.
            button1.Click -= button1_Click;
            button1.Click += button2_Click;

            // Reset the score to 0 whenever the game starts.
            score = 0;
            label6.Text = score.ToString();

            // Clear the list box of any previous scores.
            listBox1.Items.Clear();

            // Reset the total to 0 at the start of a new game.
            total = 0;
            label8.Text = total.ToString();
        }

        // This event is triggered when the "Stop" button is clicked.
        private void button2_Click(object sender, EventArgs e)
        {
            // Stop the timer.
            gameTimer.Stop();

            // Change button1 text from "Stop" back to "Start".
            button1.Text = "Start";

            // Hide button2 again since we only want the Start button visible initially.
            button2.Visible = false;

            // Remove the button2_Click event handler from button1 and re-add button1_Click
            // so that button1 again behaves like a "Start" button on the next click.
            button1.Click -= button2_Click;
            button1.Click += button1_Click;

            // Re-enable button1. Hide or disable button2.
            button1.Enabled = true;
            button2.Enabled = false;

            // Update the label8 to display the total score from the current round.
            label8.Text = total.ToString();
        }

        // Creates two random numbers and decides whether the operation will be + or -,
        // then calculates the correctAnswer and displays them on the labels.
        private void GenerateRandomQuestions()
        {
            // Generate two random integers between 1 and 50.
            a = rnd.Next(1, 51);
            b = rnd.Next(1, 51);

            // Randomly pick between 0 or 1. If 0, use "+". If 1, use "-".
            operation = rnd.Next(0, 2) == 0 ? "+" : "-";

            // Calculate correctAnswer based on the chosen operation.
            if (operation == "+")
            {
                correctAnswer = a + b;
            }
            else
            {
                correctAnswer = a - b;
            }

            // Display the values and operation on the labels.
            label5.Text = ($"{a}");
            label4.Text = ($"{operation}");
            label9.Text = ($"{b}");
        }

        // This event checks if the user pressed the Enter key while typing in textBox1.
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // If the pressed key is Enter, handle the answer submission.
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // Convert the user input from textBox1 into an integer.
                    int userAnswer = int.Parse(textBox1.Text);

                    // Check if the user answer matches the correct answer.
                    if (userAnswer == correctAnswer)
                    {
                        // If correct, add the current score to the list box.
                        listBox1.Items.Add(score);

                        // Add the score to the total.
                        total += score;

                        // Reset the score to 0.
                        score = 0;
                        label6.Text = score.ToString();

                        // Generate a new random question.
                        GenerateRandomQuestions();
                    }
                    else
                    {
                        // If incorrect, simply reset the score to 0 and generate a new question.
                        score = 0;
                        label6.Text = score.ToString();
                        GenerateRandomQuestions();
                    }
                }
                catch (FormatException)
                {
                    // If the user did not enter a valid number, show a message.
                    MessageBox.Show("Please enter only numbers.");
                }

                // Clear the text box for the next answer.
                textBox1.Clear();
            }
        }

        // This event is triggered when the list box selection changes, but it’s empty here.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
