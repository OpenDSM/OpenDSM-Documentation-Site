# Images
Documentation on all image endpoints

## Table of Contents
1. [Get Image](#get-image)
1. [Upload Image](#upload-image)
1. [Delete Image](#delete-image)
1. [Get Image Information](#get-images-info)

# Get Image
Endpoint: `/api/images/{type}/{id}/{name}`   
Method: `GET`
## Route Parameters:
[REQUIRED] `type` : `string` - Either user or product.  
[REQUIRED] `id` : `int32` - The user or product id.  
[REQUIRED] `name` : `string` - The name of the image.  

## Authentication
`NONE`   
## Example
Request:   
`/api/images/user/1/profile`   
Response:   
![Image Response](http://api.opendsm.tk/images/user/1/profile)


# Upload Image  
Endpoint: `/api/images/{type}/{id?}/{name}`      
Method: `POST`
## Route Parameters:
[REQUIRED] `type` : `string` - Either user or product.  
[REQUIRED] `id` : `int32` - The user or product id, if type is user the id is inferred.  
[REQUIRED] `name` : `string` - The name of the image.  
### Body Parameters:
[REQUIRED] `image` : `string` - The base64 image   

## Authentication
Placed in headers or cookies   
[REQUIRED] `auth_email`:`string` - The users email or username  
[REQUIRED] `auth_token`:`string` - The users login token  

## Example
Request:   
`/api/images/product/177/icon`   
`body`=>`example.base64==`   

Response:   
```json
{
    "message": "product's icon image was uploaded successfully"
}
```


# Delete Image
Endpoint: `/api/images/{type}/{id?}/{name}`   
Method: `DELETE`
## Route Parameters:
[REQUIRED] `type` : `string` - Either user or product.  
[REQUIRED] `id` : `int32` - The user or product id, if type is user the id is inferred.  
[REQUIRED] `name` : `string` - The name of the image.  

## Authentication
Placed in headers or cookies   
[REQUIRED] `auth_email`:`string` - The users email or username  
[REQUIRED] `auth_token`:`string` - The users login token  

## Example
Request:   
`/api/images/user/profile`   

Response:   
```json
{
    "message": "Profile image deleted successfully"
}
```


# Get Images Info
Endpoint: `/api/images/product/{id}`   
Method: `GET`
## Route Parameters:
[REQUIRED] `id` : `int32` - The products id   
### Authentication
`NONE`

## Example
Request:   
`/api/images/product/1`   

Response:   
```json
{
    "icon": {
        "name": "icon",
        "path": "/api/images/product/1/icon",
        "bytes": 7534,
        "size": "7.36Kb",
        "dimensions": {
            "width": 128,
            "height": 128
        }
    },
    "banner": {
        "name": "banner",
        "path": "/api/images/product/1/banner",
        "bytes": 77867,
        "size": "76.04Kb",
        "dimensions": {
            "width": 1280,
            "height": 720
        }
    },
    "gallery": [
        {
            "name": "gallery_0",
            "path": "/api/images/product/1/gallery_0",
            "bytes": 86001,
            "size": "83.99Kb",
            "dimensions": {
                "width": 1280,
                "height": 720
            }
        },
        {
            "name": "gallery_1",
            "path": "/api/images/product/1/gallery_1",
            "bytes": 78254,
            "size": "76.42Kb",
            "dimensions": {
                "width": 1280,
                "height": 720
            }
        },
        {
            "name": "gallery_2",
            "path": "/api/images/product/1/gallery_2",
            "bytes": 98240,
            "size": "95.94Kb",
            "dimensions": {
                "width": 1280,
                "height": 720
            }
        }
    ],
    "bytes": 347896,
    "size": "339.74Kb",
    "files": 5
}
```