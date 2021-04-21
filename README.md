# Service Bus Subscription --> Azure Function --> Event Grid --> Event Grid Subscription --> Azure Function (Simulate Webhook)

The requirement was to have a webhook subscriber for sevice bus topic. This is not in-build in service bus, but avaliable in event grid. In order to bridge the gap a azure function 
is created that can subscribe to service bus topic and send it to event grid. The event grid can send the same event to a registered webhook subscriber.

In this repository there are two Azure functions

1) ProcessMessageOnSBEvents001 - Trigger Service Bus Topic and output is event grid
2) WebhookEvents - Webhook as a subscriber to event grid 



