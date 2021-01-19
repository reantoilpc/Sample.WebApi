# 專案範例

## 環境說明

- WebApi Mvc 架構
- dotnet Core 5.0

## 使用套件

- Swashbuckle

## Sample.WebApi

實作 Filters & Attribute

- ActionResultFilter 當 API 呼叫成功，回傳格式
- ExceptionResultFilter 當 Exception 發生時，回傳格式
- JwtMiddleware 身份驗證器
- AuthorizeAttribute 

Extension

- FilterExtension
- ServiceConfigurationExtension

### Sample.Service

- AuthenticationService Token 產生器
- UserService 使用者資料查詢
