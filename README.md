# Notification service

Currently only works with Amazon SES mail send request. In the near future following features will be added. Notify.API does not use authentication method because this service is designed to handle authenticated requests through API Gateway or in-network requests from other services.

AWS credentials must be setted in enviroment variables like this

```

AWS_ACCESS_KEY_ID
AWS_SECRET_ACCESS_KEY

```


### Mail

- [x] AWS SES
- [ ] SendinBlue
- [ ] SendGrid

### Push notification

- [ ] AWS SNS
