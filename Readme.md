# .NET Background Service demo

## What is a background service? 
In ASP.NET Core, background tasks can be implemented as 
hosted services. A hosted service is a class with background
task logic that implements the IHostedService interface.
<br><br>
BackgroundService provides a simple and extensible way to
write background tasks. It also requires minimal 
plumbing to make it production-ready, 
which makes it my preferred solution for writing 
background tasks. More details [here!](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/host/hosted-services?view=aspnetcore-7.0&tabs=visual-studio)

## Which tecnology is behind this repo? 
1. ASP.NET Core 7.0
1. C# 9.0

## What is the scope of this repo? 
1. Consume data from a queue from the message broker (RabbitMQ)
1. Save info to logger service (Web API)
1. Send info to the final consumer (REST service)

## License
The Laughing Out Loud License (LOL)

Version 1.0, July 2023

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

1. You must acknowledge that the Software is hilarious and make at least one person laugh when using it.
2. You must not claim that you wrote the original Software or that you are smarter than the original author(s).
3. You must not use the Software for evil purposes or to hurt anyone's feelings, unless they really deserve it.
4. You must not sue the original author(s) or anyone else for any damages arising from the use of the Software, even if it causes your computer to explode or your cat to run away.
5. You must share any funny modifications or improvements that you make to the Software with the original author(s) and the world.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
