# DEV-9177
DEV-9177 - Auto UI ServiceStack - repro of stack error in browser with large number of services

This is a solution to repro an issue I've come across with the Auto UI forms ServiceStack 6.03 generates.

The issue is javascript error in the browser : "Uncaught RangeError: Maximum call stack size exceeded".  Once this error occurs, it has knock-on effects and things in the browser don't work right after that (particularly if you have routes requiring authentication).

There is a t4 template in the ServiceInterface project which generates service classes, request and response classes automatically.  In the GenerateClasses.tt there are some variables to set the values for the number of service classes to generate.

In my findings, setting the number of service classes to 515 or greater will repro the problem in Edge.  For Chrome, this value needs to be 617 or greater.

To repro the issue, run the solution and your default browser will open.

Inspect the browser and show the console.

Then click on any of the RequestClasses in the left pane - the "Uncaught RangeError: Maximum call stack size exceeded" error will be seen in the console.
![image](https://user-images.githubusercontent.com/3487727/157394123-44f66dd8-dfa2-4ffe-b606-e0ae32f0c718.png)
