using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WindowsFormsApp1
{
    [TestClass]
    public class MyLibraryTests
    {
        private const string connectionString = "Data Source=ADCLG1;Initial Catalog=stepanov2zadanie;Integrated Security=True";

        [TestMethod]
        public void ConnectToDatabase_SuccessfulConnection()
        {
            // Arrange
            MyLibrary myLibrary = new MyLibrary(connectionString);

            // Act
            bool isConnected = myLibrary.ConnectToDatabase(); // assuming the ConnectToDatabase() method returns a boolean indicating the connection status

            // Assert
            Assert.IsTrue(isConnected, "Expected the c" +
                "onnection to be successful");
        }

        [TestMethod]
        public void DisplayMessage_OutputMessageToConsole()
        {
            // Arrange
            string message = "Hello, world!";
            MyLibrary myLibrary = new MyLibrary(connectionString);

            // Act
            myLibrary.DisplayMessage(message);
        }


        [TestMethod]
        public void DisplayMessage_OutputMessageToConsol11e()
        {
            // Arrange
            string message = "Hello, вФТНФ!";
            MyLibrary myLibrary = new MyLibrary(connectionString);

            // Act
            myLibrary.DisplayMessage(message);
        }
        [TestMethod]
        public void DisplayMessage_OutputMessageToCons543ol11e()
        {
            // Arrange
            string message = "Hello, вФТНВАПВПАФ!";
            MyLibrary myLibrary = new MyLibrary(connectionString);

            // Act
            myLibrary.DisplayMessage(message);
        }
        [TestMethod]
        public void DisplayMessage_OutputMessageToConsol78611e()
        {
            // Arrange
            string message = "Hello, вФТЫВАВЫАВЫАВЫАНФ!";
            MyLibrary myLibrary = new MyLibrary(connectionString);

            // Act
            myLibrary.DisplayMessage(message);
        }
        [TestMethod]
        public void DisplayMessage_OutputMessageToConsol14561e()
        {
            // Arrange
            string message = "Hello, вФТНЫВАВЫАВЫАВЫАВЫАВЫАФ!";
            MyLibrary myLibrary = new MyLibrary(connectionString);

            // Act
            myLibrary.DisplayMessage(message);
        }
        [TestMethod]
        public void DisplayMessage_OutputMessageToConsol5411e()
        {
            // Arrange
            string message = "Hello, вФТНВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫФ!";
            MyLibrary myLibrary = new MyLibrary(connectionString);

            // Act
            myLibrary.DisplayMessage(message);
        }
        [TestMethod]
        public void DisplayMessage_OutputMessageToConso78l11e()
        {
            // Arrange
            string message = "Hello, вФТНВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВЫАВАЫФ!";
            MyLibrary myLibrary = new MyLibrary(connectionString);

            // Act
            myLibrary.DisplayMessage(message);
        }
        [TestMethod]
        public void DisplayMessage_OutputMessageToCons354ol11e()
        {
            // Arrange
            string message = "Hello, вФВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫВАЫТНФ!";
            MyLibrary myLibrary = new MyLibrary(connectionString);

            // Act
            myLibrary.DisplayMessage(message);
        }
    }
}
