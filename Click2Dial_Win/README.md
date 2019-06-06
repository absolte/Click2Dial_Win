# Click2Dial_Win

Click2Dial_Win is a C# program that adds Click to Dial capabilities using CallTo, sip, and tel protocols in Windows 10.

## Installation
GitHub:
Create and use the .msi install file.

Otherwise use the .msi install file provided.

## Usage
Make sure to go o Default Apps\Choose default apps by protocol and set CallTo, sip, and tel to default to Click2Dial_Win.
When a CallTo, sip, or tel link is clicked the Click2Dial_Win.exe will run, passing the protocol and telephone number to the code, which will create a text file on the desktop with those arguments. 
The file destination can be change to be used by a VOIP server or rewritten to pass the argument directly to the API of the VOIP system.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
N/A