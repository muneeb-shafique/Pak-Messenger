<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Pak Messenger</title>
</head>
<body>

<h1>Pak Messenger</h1>
    <p><strong>Pak Messenger</strong> is a C#-based messaging application built on the .NET Framework, featuring a modern user interface powered by Bunifu UI. The application provides a secure, user-friendly way to connect and communicate with friends by verifying your number and offering direct peer-to-peer messaging without the need for cloud storage. The following section will provide you with detailed information on its features, setup, and functionality.</p>

<h2>Features</h2>
    <table>
        <tr>
            <th>Feature</th>
            <th>Description</th>
        </tr>
        <tr>
            <td>OTP-based Authentication</td>
            <td>The application starts by verifying your phone number using OTP (One-Time Password). The OTP is sent to your phone through an API integration, ensuring that only authorized users can log in.</td>
        </tr>
        <tr>
            <td>Friendship System</td>
            <td>Each user gets a unique Friend ID. You can share this Friend ID with others. Once someone enters your Friend ID in their application, you both become friends, enabling you to message each other directly.</td>
        </tr>
        <tr>
            <td>Direct Messaging</td>
            <td>Messages are transferred directly between users' devices. Unlike traditional messaging systems that rely on cloud storage, Pak Messenger ensures that your messages remain local and secure, enhancing privacy.</td>
        </tr>
        <tr>
            <td>HTML & CSS for Message Formatting</td>
            <td>The application allows message formatting using HTML and CSS. This provides a more customized and aesthetically pleasing chat experience, giving users control over the appearance of their conversations.</td>
        </tr>
        <tr>
            <td>No Cloud Storage</td>
            <td>Pak Messenger operates on a peer-to-peer messaging model. No cloud storage is involved, which means that all your messages are only accessible on the devices involved in the conversation, ensuring your privacy is maintained.</td>
        </tr>
    </table>

 <h2>How It Works</h2>
    <p>Pak Messenger operates using a simple but secure process. Here’s a step-by-step breakdown:</p>
    <ol>
        <li><strong>Launch the Application:</strong> Upon launching Pak Messenger, you will be prompted to enter your phone number.</li>
        <li><strong>OTP Verification:</strong> After entering your number, an OTP is sent to your phone. Enter the OTP into the application to proceed.</li>
        <li><strong>Create a Friend ID:</strong> After verification, the application generates a unique Friend ID for you. This ID is used for adding friends within the app.</li>
        <li><strong>Share Your Friend ID:</strong> Share your Friend ID with someone you want to communicate with.</li>
        <li><strong>Friend Request:</strong> When the other person enters your Friend ID, you both become friends and can start messaging.</li>
        <li><strong>Start Messaging:</strong> Send messages directly to your friend's computer. Messages are exchanged directly between your devices, ensuring privacy.</li>
    </ol>
  <h2>Technologies Used</h2>
    <p>The following technologies were utilized in the development of Pak Messenger:</p>
    <ul>
        <li><strong>C#:</strong> The core programming language used for developing the application.</li>
        <li><strong>.NET Framework:</strong> Provides the underlying framework for the application, ensuring compatibility and performance.</li>
        <li><strong>Bunifu UI:</strong> A modern user interface toolkit that enables a visually appealing design and user-friendly experience.</li>
        <li><strong>HTML & CSS:</strong> Used for formatting messages and creating a customizable chat environment.</li>
        <li><strong>API Integration:</strong> Used to send OTP to the user’s phone for secure authentication.</li>
    </ul>

<h2>Benefits</h2>
    <p>Pak Messenger offers several key benefits:</p>
    <ul>
        <li><strong>Enhanced Privacy:</strong> No messages are stored in the cloud. Communication is entirely between the devices of the sender and receiver.</li>
        <li><strong>Fast & Secure:</strong> OTP verification ensures that only authorized users can access the application, while direct peer-to-peer messaging guarantees fast delivery.</li>
        <li><strong>User-Friendly Interface:</strong> Thanks to Bunifu UI, the application features a clean, modern, and easy-to-navigate design.</li>
        <li><strong>Customization:</strong> The use of HTML and CSS allows for customizing the chat experience, such as changing message styles and layouts.</li>
    </ul>

 <h2>Installation Guide</h2>
    <p>To set up Pak Messenger, follow these steps:</p>
    <ol>
        <li>Clone the repository to your local machine:</li>
        <pre><code>git clone https://github.com/muneeb-shafique/pak-messenger.git</code></pre>
        <li>Open the project in Visual Studio.</li>
        <li>Ensure you have the .NET Framework installed on your machine. If not, download and install it from <a href="https://dotnet.microsoft.com/download/dotnet-framework" target="_blank">here</a>.</li>
        <li>Build the solution and run the application.</li>
        <li>Follow the on-screen instructions to complete the OTP verification and start messaging.</li>
    </ol>

<h2>Contributing</h2>
    <p>We welcome contributions to Pak Messenger! If you find any bugs or want to add new features, feel free to fork the repository and submit a pull request.</p>
    <p>For any issues, you can open an <a href="https://github.com/muneeb-shafique/Pak-Messenger/issues" target="_blank">issue</a> on the GitHub repository.</p>

   <h2>License</h2>
    <p>Pak Messenger is open-source software.</p>

</body>
</html>
