# README

After trying to debug a console application on net core 3 I discovered that traces were not being sent to application insights.
This repository is just a friendly reminder of my initial approach and a working version of it.

On commit https://github.com/adrianabreu/sample-insights-logging-net-core-console/commit/223c93a05f853ccb575d3dabfd9884fbb2c960b4 I expected the simple telemetry configuration to work. 

But there is a pretty good (but hidden) doc from microsoft relating how console applications should behave https://docs.microsoft.com/en-us/azure/azure-monitor/app/worker-service#configure-the-application-insights-sdk

This current repo should work as a reminder for this kind of situation.
