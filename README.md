# pub-broker-sub
A simple Publisher-Subscriber application.
<br/>
<img width="354" alt="untitled" src="https://user-images.githubusercontent.com/47944245/53300304-55534280-3880-11e9-97e7-2a0ddf589669.png">
<br/>
In this example, we have:
1. publisher  - publish the temperature or pressure changed message(which are a topic and current value)to broker
2. broker     - recieve the topics(temperature or pressure) from publisher and forward it to whoever subscribe to respective topics
3. subscriber - subscribe to the topics which he is interested to.
<br/>
The Scenario:
We have few digital devices used to collect KLCC area's temperature and pressure. And now we would like to share the collected data with interested parties. Radio stations (eg: ExampleRadio) and websites(eg: ExampleWebsite) are interested to get our data for reporting and forecasting. 
ExampleRadio is interested to get our 'temperature' topic while ExampleWebsite interests our 'temperature' and 'pressure' topics. Whenever there is a new update from any digital device, publish will send the latest update to broker, broker will forward the message to whoever is interested to the topics. For example, there is a change in temperature, broker will forward the message to website and radio. If there is a change in pressure, broker will forward the message to radio only. 
