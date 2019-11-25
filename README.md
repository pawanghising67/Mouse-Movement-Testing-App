# Mouse-Movement-Testing-App
Windows Form Application to test mouse movement and other variables to measure Fitts law
Instructions on How to run the test and print the csv file for the data.

1. Download the folder and right click > Extract All. (Unzip)

2. Open you visual studio by right clicking >Run as administrator.

Note: Make sure you run as Administrator.

3. Go in File an and open the extracted folder and click open file highlighted below.

4. So after you open the .sln file. Go to solution explorer. It’s on the right hand side of Visual studio.

If you can’t find solution explorer click view > solution Explorer.

5. Open the MouseMove.cs by double clicking it. The screen below will appear. Then Press F7. Or you can right click on Mouse.Move and click <>View Code.

6. Now go to the line 775 of the MouseMove.cs file. We are changing this so we get the data to our Notepad.txt (csv) file.

Open a notepad file and save it in C:\\ of your computer. For example before starting the test for Pawan. I will open a notepad file and save it as “ Pawan.txt” on my C:\\ Drive.

This is the code and you change the highlighted part depending upon where in the computer you have saved your notepad file.

File.WriteAllText("C:\\test.txt", csv.ToString());

Change the test.txt to Pawan.txt. File.WriteAllText("C:\\Pawan.txt", csv.ToString());

Now this is changing the path for the file. Change it each time you test it to a new participants with their name. Now all you need to do is press F5 or the Start Button as shown. And START the test.
