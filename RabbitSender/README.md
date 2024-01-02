Docker :
PS C:\Windows\system32> docker run -d  --hostname rmq  --name  rabbit-server  -p  8080:15672  -p 5672:5672  rabbitmq:3-management
---
in .net:
we have a solution tow project
1- RabitSender  
   in dependencies right click and select Manage NuGet packages
   serach and install : Rabbitmq.client

2- RabbitReceiver1
 copy from R1bitSender.csproj
  <ItemGroup>
    <PackageReference Include="RabbitMQ.Client" Version="6.8.1" />
  </ItemGroup>
  
  to 

  RabbitReceiver1.csproj


