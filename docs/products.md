# Products
Documentation on all product endpoints

## Table of Contents
1. [Get Products](#get-products)
1. [Get Product](#get-product)
1. [Create Product](#create-product)
1. [Delete Product](#delete-product)
1. [Get Product Tags](#get-product-tags)

# Get Products
Endpoint: `/api/products`   
Method: `GET`

## Authentication
`NONE`   
## Example
Request:   
`/api/products?type=popular&page=2&items_per_page=50`   
Response:   
```json
[
    {
        "id": 1,
        "name": "Product Name",
        "about": "",
        "shortSummery": "This is a product",
        "keywords": [
            "keywords",
            "example",
            "test",
            "product"
        ],
        "tags": [
            1,
            3,
            5
        ],
        "platforms": [],
        "market": {
            "price": 0,
            "salePrice": -1,
            "onSale": false,
            "subscription": false
        },
        "user": {
            "id": 1,
            "name": "John Doe"
        },
        "stats": {
            "rating": 0,
            "totalDownloads": 0,
            "totalWeeklyDownloads": 0,
            "totalPageViews": 0
        },
        "youtube": {
            "hasYoutubeVideo": false,
            "youtubeKey": ""
        },
        "git": {
            "username": "john.doe@example.com",
            "repository": "Example-Product",
            "useReadme": true
        }
    },

    {
        "id": 1,
        "name": "Product Name",
        "about": "",
        "shortSummery": "This is a product",
        "keywords": [
            "keywords",
            "example",
            "test",
            "product"
        ],
        "tags": [
            1,
            3,
            5
        ],
        "platforms": [],
        "market": {
            "price": 0,
            "salePrice": -1,
            "onSale": false,
            "subscription": false
        },
        "user": {
            "id": 1,
            "name": "John Doe"
        },
        "stats": {
            "rating": 0,
            "totalDownloads": 0,
            "totalWeeklyDownloads": 0,
            "totalPageViews": 0
        },
        "youtube": {
            "hasYoutubeVideo": false,
            "youtubeKey": ""
        },
        "git": {
            "username": "john.doe@example.com",
            "repository": "Example-Product",
            "useReadme": true
        }
    }
]
```


# Get Product  
Endpoint: `/api/products/{id}`      
Method: `GET`
## Route Parameters:
[REQUIRED] `id` : `int32` - The product id.  

## Authentication
`NONE`

## Example
Request:   
`/api/products/1`   

Response:   
```json
{
    "id": 1,
    "name": "Product Name",
    "about": "",
    "shortSummery": "This is a product",
    "keywords": [
        "keywords",
        "example",
        "test",
        "product"
    ],
    "tags": [
        1,
        3,
        5
    ],
    "platforms": [],
    "market": {
        "price": 0,
        "salePrice": -1,
        "onSale": false,
        "subscription": false
    },
    "user": {
        "id": 1,
        "name": "John Doe"
    },
    "stats": {
        "rating": 0,
        "totalDownloads": 0,
        "totalWeeklyDownloads": 0,
        "totalPageViews": 0
    },
    "youtube": {
        "hasYoutubeVideo": false,
        "youtubeKey": ""
    },
    "git": {
        "username": "john.doe@example.com",
        "repository": "Example-Product",
        "useReadme": true
    }
}
```


# Create Product
Endpoint: `/api/products`   
Method: `POST`
## Form Parameters:
[REQUIRED] `name`:`string` - The name of the product  
[REQUIRED] `git_repo_name` : `string` - The github repository name   
[REQUIRED] `short_summery` : `string` - The short summery   
[OPTIONAL] `yt_key` : `string` - The youtube video trailer key   
[REQUIRED] `subscription`:`bool` - If product is a subscription or not  
[REQUIRED] `use_git_readme`:`bool` - If the product page should use git readme or a custom one  
[REQUIRED] `price`:`float` - The price of the product or 0 for free  
[REQUIRED] `keywords` : `string` - Any keywords to help with SEO  
[REQUIRED] `tags` :  `string` - Any tags to help with SEO  
[REQUIRED] `icon` : `string` - The base64 icon image  
[REQUIRED] `banner` : `string` - The base64 banner image  

## Authentication
Placed in headers or cookies   
[REQUIRED] `auth_email`:`string` - The users email or username  
[REQUIRED] `auth_token`:`string` - The users login token  

## Example
Request:   
`/api/products`   
`name`=>`Product Name`   
`git_repo_name`=>`Example-Product`   
`short_summery`=>`This is a product`   
`yt_key`=>`dQw4w9WgXcQ`   
`subscription`=>`false`   
`use_git_readme`=>`false`   
`price`=>`0`   
`keywords`=>`keywords;example;test;product`  
`tags`=>`desktop;utility;open source;`  
`icon`=>`base64==`  
`banner`=>`base64==`  

Response:   
```json
{
    "id": 177,
    "name": "Product Name",
    "about": "",
    "shortSummery": "This is a product",
    "keywords": [
        "keywords",
        "example",
        "test",
        "product"
    ],
    "tags": [
        1,
        3,
        5
    ],
    "platforms": [],
    "market": {
        "price": 0,
        "salePrice": -1,
        "onSale": false,
        "subscription": false
    },
    "user": {
        "id": 256,
        "name": "John Doe"
    },
    "stats": {
        "rating": 0,
        "totalDownloads": 0,
        "totalWeeklyDownloads": 0,
        "totalPageViews": 0
    },
    "youtube": {
        "hasYoutubeVideo": true,
        "youtubeKey": "dQw4w9WgXcQ"
    },
    "git": {
        "username": "john.doe@example.com",
        "repository": "Example-Product",
        "useReadme": false
    }
}
```

# Delete Product
Endpoint: `/api/products/{id}`   
Method: `DELETE`
## Route Parameters:
[REQUIRED] `id` : `int32` - The product id  

## Authentication
Placed in headers or cookies   
[REQUIRED] `auth_email`:`string` - The users email or username  
[REQUIRED] `auth_token`:`string` - The users login token  

## Example
Request:   
`/api/products/177`   

Response:   
```json
{
    "message": "Product deleted!"
}
```


# Get Product Tags
Endpoint: `/api/products/tags`   
Method: `GET`
### Authentication
`NONE`

## Example
Request:   
`/api/products/tags`   

Response:   
```json
[
    {
        "id": 1,
        "name": "Desktop"
    },
    {
        "id": 2,
        "name": "Server"
    },
    {
        "id": 3,
        "name": "Utility"
    },
    {
        "id": 4,
        "name": "Productivity"
    },
    {
        "id": 5,
        "name": "Open Source"
    },
    {
        "id": 6,
        "name": "CLI"
    },
    {
        "id": 7,
        "name": "Web UI"
    },
    {
        "id": 8,
        "name": "Gaming"
    },
    {
        "id": 9,
        "name": "Entertainment"
    }
]
```