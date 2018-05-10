# ARS.IfxConnection
Connection tests between Informix in Docker and C#

## Docker
1. Download informix docker image from [here](https://hub.docker.com/r/ibmcom/informix-innovator-c/) and follow the instructions.
2. Go to _/opt/ibm/informix/sqlhosts_, check the name in **drsoctcp** protocol and edit the hostname with **0.0.0.0**.<br> Like the following image: <br>
![alt text](https://github.com/andresrsanchez/ARS.IfxConnection/blob/master/images/sqlhosts_DRDA_Name.PNG "DRDA")
3. Edit in _/opt/ibm/informix/onconfig_ **DBSERVERALIASES** key with the value in step 2 (informix_dr).
4. Restart informix server with "onmode -ku -y" and initialize with "oninit". 
5. Check DRDA Connection (9089 port) with **netstat** inside your container. 

## CSharp

1. In your project add **IBM.Data.DB2.Core** nuget.
2. In your connection string add this parameter: "Persist Security Info=True;Authentication=Server".
3. Done!




