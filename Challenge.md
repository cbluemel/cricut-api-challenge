# Cricut Orders Challenge

This project is a REST Api that simulates a simple order system. Please complete the following tasks related to this service.

### 1. Fix the bug in the endpoint POST /v1/orders. The bug report states the following.

```
Title: The order service is not applying the discount correctly.
Steps To Reproduce:
1. Create a new order with the following information.
{
    "customer": {
        "id": 1,
        "name": "John Doe",
        "address": "123 Street",
        "email": "john@cool.com"
    },
    "orderItems": [
        {
            "product": {
                "id": 1,
                "name": "Product 1",
                "price": 13.50
            },
            "quantity": 1
        },
        {
            "product": {
                "id": 2,
                "name": "Product 2",
                "price": 11.50
            },
            "quantity": 1
        }
    ]
}
2. Check the order total in the response

Expected Results:
The order total should have a discount applied when the order is $25 or more. 
The discount should not be applied when the order total is less than $25. 
The order above should have the 10% discount applied and result in a total of $22.50

Actual Results:
The order total does not have the discount applied and is displaying $25
```

### 2. Create a new GET endpoint that returns the orders for a given customer id. There are some static orders for the customer ids 12345 and 54321.
 
### 3. Ensure all unit tests are still passing. 

### Notes: 
You do not need to modify anything within the OrderStore class. All other classes and tests can be modified as needed to complete the challenge.