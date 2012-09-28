Notes:

To run the sample quickly, run MicroservicesHost (console app) from VS or the double click the exe if its already been compiled.
Open up a browser and enter http://localhost:8000 and try out the routes (see below)

To allow access for for a particular uer to access this port/url. Default is system/nt user. Allows a process to access this port
netsh http add urlacl url=http://+:8000/<name of service> user="<windows user name>"

user cURL to test the routes:
 GET: curl http://localhost:8000/jokes --> returns all 
 GET: curl http://localhost:8000/jokes/1 --> returns one
 POST: curl -X POST http://localhost:8000/jokes -d '{"OneLiner":"I am new"}' -H "Content-type: application/json"
 
 
Downloaded git from git-scm, and using gitbash.
Install Git Bash...

*Download Console2
*Create a dir somewhere to hold your custom scripts (which will be added to your environment PATH variable):
e.g. 
C:\Software\bin
Create a file called "bash" in there:
C:\Software\bin\bash

*Put this in the file: "C:\Program Files (x86)\Git\bin\sh.exe" --login -i
*Edit your env variables and append "C:\Software\bin" to the PATH.
*Open Console2
*Type "bash"


