using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        private List<Image> cardImages;  // List of card images
        private List<string> cardNames;  // List of card names
        private List<PictureBox> topCards;  // Holds the top row of cards
        private List<PictureBox> bottomCards;  // Holds the bottom row of cards

        public Form1()
        {
            InitializeComponent();
            LoadCardImages();
            InitializeGame();
        }

        // Load card images and names into lists
        private void LoadCardImages()
        {
            cardImages = new List<Image>
            {
                Properties.Resources.Card1,  // Add your card images here
                Properties.Resources.Card2,
                Properties.Resources.Card3,
                Properties.Resources.Card4,
                Properties.Resources.Card5,
                Properties.Resources.Card6,
                Properties.Resources.Card7,
                Properties.Resources.Card8,
                Properties.Resources.Card9,
                Properties.Resources.Card10
            };

            cardNames = new List<string>
            {
                "Card 1",
                "Card 2",
                "Card 3",
                "Card 4",
                "Card 5",
                "Card 6",
                "Card 7",
                "Card 8",
                "Card 9",
                "Card 10"
            };
        }

        // Initialize the game and set up event handlers for picture boxes
        private void InitializeGame()
        {
            // Add top and bottom cards to lists
            topCards = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            bottomCards = new List<PictureBox> { pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };

            // Set click event for each PictureBox (top row only should display cards)
            for (int i = 0; i < topCards.Count; i++)
            {
                int index = i;  // Prevent closure issue with for loop
                topCards[i].Click += (sender, e) => ShowCard(index);
            }

            label1.Text = "Click a card to reveal it!";
            label2.Text = "";
        }

        // Show the card when a PictureBox is clicked and display the card name
        private void ShowCard(int index)
        {
            topCards[index].Image = cardImages[index];  // Show the image behind the card
            label2.Text = cardNames[index];  // Display the card name in the second label
        }

        // Reset the deck to hide the cards
        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (var card in topCards)
            {
                card.Image = null;  // Clear images (assuming you want to hide them)
            }
            label2.Text = "";  // Clear the second label text
        }

        // Exit the application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}