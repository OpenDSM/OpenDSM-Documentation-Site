# Users
Documentation on all user endpoints

## Table of Contents
1. [Get User](#get-user)
1. [Create User](#create-user)
1. [Activate Developer Account](#activate-developer-account)
1. [Validate Login Credentials](#validate-account)
1. [Validate Login Credentials with Token](#validate-account-with-token)
1. [Update User Settings](#update-settings)
1. [Get User Repositories](#get-user-repositories)

# Get User
Get a user and all of its information  
Endpoint: `/api/user/{id}`   
Method: `GET`
## Route Parameters:
[REQUIRED] `id` : `int32` - The users unique id.  
## Query Parameters
[OPTIONAL] `includeImages` : `boolean` - If the response should include base64 representation of the users images
## Authentication
`NONE`   
## Example
Request:   
`/api/user/1?includeImages=false`   
Response:   
```json
{
    "id": 1,
    "username": "John Doe",
    "email": "john.doe@example.com",
    "token": "",
    "about": "",
    "createdProducts": [],
    "ownedProducts": {},
    "git": {
        "hasGitReadme": true,
        "useReadme": true,
        "isDeveloperAccount": true,
        "readme": ""
    },
    "images": {
        "profile": {
            "base64": "",
            "path": "/api/images/user/1/profile",
            "mime": "image/jpeg"
        },
        "banner": {
            "base64": "",
            "path": "/api/images/user/1/banner",
            "mime": "image/jpeg"
        }
    }
}
```


# Create User  
Endpoint: `/api/user`   
Method: `POST`
### Form Parameters:
[REQUIRED] `email` : `string` - The users email   
[REQUIRED] `username` : `string` - The users username   
[REQUIRED] `password` : `string` - The users password   

## Authentication
`NONE`   

## Example
Request:   
`/api/user`   
`email`=>`john.doe@example.com`   
`username`=>`supercatlover123`   
`password`=>`!Jc112%kC$#42`   

Response:   
```json
{
    "success": true,
    "message": "Account Created Successfully",
    "user": {
        "id": 1,
        "username": "John Doe",
        "email": "john.doe@example.com",
        "token": "",
        "about": "",
        "createdProducts": [],
        "ownedProducts": {},
        "git": {
            "hasGitReadme": false,
            "useReadme": false,
            "isDeveloperAccount": false,
            "readme": ""
        },
        "images": {
            "profile": {
                "base64": "",
                "path": "/api/images/user/1/profile",
                "mime": "image/jpeg"
            },
            "banner": {
                "base64": "",
                "path": "/api/images/user/1/banner",
                "mime": "image/jpeg"
            }
        }
    }
}
```


# Activate Developer Account
Endpoint: `/api/user/git/activate`   
Method: `POST`
## Form Parameters
[REQUIRED] `git_username` : `string` - The username used for github  
[REQUIRED] `git_token` : `string` - The access token used for github  
## Authentication
Placed in headers or cookies   
[REQUIRED] `auth_email`:`string` - The users email or username  
[REQUIRED] `auth_token`:`string` - The users login token  

## Example
Request:   
`/api/user/git/activate`   
`git_username`=>`john.doe@example.com`   
`git_token`=>`fdfasdfas==`   

Response:   
```json
{
    message: "Account activated successfully"
}
```


# Validate Account
Checks if user credentials are correct.  
Endpoint: `/api/user/validate`   
Method: `POST`
## Form Parameters
[REQUIRED] `username` : `string` - The users login username or email  
[REQUIRED] `password` : `string` - The users login password  
### Authentication
`NONE`

## Example
Request:   
`/api/user/validate`   
`username`=>`john.doe@example.com`   
`password`=>`!Jc112%kC$#42`   

Response:   
```json
{
    "success": true,
    "message": "Logged in Successfully",
    "user": {
        "id": 1,
        "username": "John Doe",
        "email": "john.doe@example.com",
        "token": "",
        "about": "",
        "createdProducts": [],
        "ownedProducts": {},
        "git": {
            "hasGitReadme": false,
            "useReadme": false,
            "isDeveloperAccount": false,
            "readme": ""
        },
        "images": {
            "profile": {
                "base64": "",
                "path": "/api/images/user/1/profile",
                "mime": "image/jpeg"
            },
            "banner": {
                "base64": "",
                "path": "/api/images/user/1/banner",
                "mime": "image/jpeg"
            }
        }
    }
}
```


# Validate Account with Token
Checks if user credentials are correct.  
Endpoint: `/api/user/validate/token`   
Method: `POST`
## Form Parameters
[REQUIRED] `username` : `string` - The users login username or email  
[REQUIRED] `token` : `string` - The users login token  
### Authentication
`NONE`

## Example
Request:   
`/api/user/validate/token`   
`username`=>`john.doe@example.com`   
`token`=>`fdfasdfas==`   

Response:   
```json
{
    "success": true,
    "message": "Logged in Successfully",
    "user": {
        "id": 1,
        "username": "John Doe",
        "email": "john.doe@example.com",
        "token": "",
        "about": "",
        "createdProducts": [],
        "ownedProducts": {},
        "git": {
            "hasGitReadme": false,
            "useReadme": false,
            "isDeveloperAccount": false,
            "readme": ""
        },
        "images": {
            "profile": {
                "base64": "",
                "path": "/api/images/user/1/profile",
                "mime": "image/jpeg"
            },
            "banner": {
                "base64": "",
                "path": "/api/images/user/1/banner",
                "mime": "image/jpeg"
            }
        }
    }
}
```


# Update Settings
Endpoint: `/api/user/{name}`   
Method: `PATCH`
## Route Parameters
[REQUIRED] `name` : `string` - The name of the setting  
## Body
[REQUIRED] `value` : `string` - The value of the setting  

## Authentication
Placed in headers or cookies   
[REQUIRED] `auth_email`:`string` - The users email or username  
[REQUIRED] `auth_token`:`string` - The users login token  

## Example
Request:   
`/api/user/username`   
`value`=>`John Doe`   

Response:   
```json
{
    message: "'username' has been updated"
}
```

# Get User Repositories
The users developer account must be active - [See Activate Developer](#activate-developer-account)  
Endpoint: `/api/user/git/repositories`   
Method: `GET`

## Authentication
Placed in headers or cookies   
[REQUIRED] `auth_email`:`string` - The users email or username  
[REQUIRED] `auth_token`:`string` - The users login token  

## Example
Request:   
`/api/user/git/repositories`   

Response:   
```json
[
    {
        "id": 533964280,
        "name": "OpenDSM-API-Server"
    },
    {
        "id": 533965548,
        "name": "OpenDSM-CLI"
    },
    {
        "id": 533974976,
        "name": "OpenDSM-Dashboard"
    },
    {
        "id": 533990739,
        "name": "OpenDSM-Documentation-Site"
    },
    {
        "id": 533964745,
        "name": "OpenDSM-Launcher"
    },
    {
        "id": 533976698,
        "name": "OpenDSM-Web-Server"
    },
    {
        "id": 533966173,
        "name": "OpenDSM.JS"
    },
    {
        "id": 533965754,
        "name": "OpenDSM.NET"
    }
]
```