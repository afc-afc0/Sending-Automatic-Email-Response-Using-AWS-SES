# Sending-Automatic-Email-Response-Using-AWS-SES

Created an email service for freelance project.

1) We get the user input from Razor Page
2) After the routing and the data binding, we control if the data is valid through data annotations
3) Controller sends the validated data to AWSLibrary
4) With AWS SDK, we send data to SES(Simple Email Service)
5) SES sends the email to S3 for storage 
6) Client gets the response




You can use you by injecting the dependency and set the options in extension method otherwise, default values will be used.
![Extension](https://user-images.githubusercontent.com/37782582/129299492-294f9a0b-f0fa-45da-b1dc-65559d612c39.PNG)
![DI](https://user-images.githubusercontent.com/37782582/129299359-dac13ef1-f4b3-4452-841f-54756f2f08a1.PNG)
![Capture](https://user-images.githubusercontent.com/37782582/129300864-65faba3f-5075-4c52-847e-9079418f5940.PNG)
![Input](https://user-images.githubusercontent.com/37782582/129301020-803b488c-d759-4e5f-bb2a-97310e4cf0ad.PNG)
![Received](https://user-images.githubusercontent.com/37782582/129300842-dd229553-e81b-45d1-9c70-d7a743901a66.PNG)


