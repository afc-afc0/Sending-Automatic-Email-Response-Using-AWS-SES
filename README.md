# Sending-Automatic-Email-Response-Using-AWS-SES

Created an email service for freelance Appointment Website project.

1) We get the user input from Razor Page
2) After the routing and the data binding we control if the data is valid
3) We send the validated data to AWSLibrary
4) Using AWS SDK we send data to SES(Simple Email Service)
5) SES sends the email to S3 storage
6) Client gets the response


![Capture](https://user-images.githubusercontent.com/37782582/129132937-af50e277-2929-4621-94bf-13d4fca6eb73.PNG)
![SNS](https://user-images.githubusercontent.com/37782582/129132242-bf829e0d-e934-4ae6-aeb5-764482dddd45.PNG)

If you want to use you can just inject the dependency and set the options if you want otherwise default values will be used
![Extension](https://user-images.githubusercontent.com/37782582/129299492-294f9a0b-f0fa-45da-b1dc-65559d612c39.PNG)
![DI](https://user-images.githubusercontent.com/37782582/129299359-dac13ef1-f4b3-4452-841f-54756f2f08a1.PNG)

