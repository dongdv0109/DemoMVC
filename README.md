# ASP.NET Zero – Nền tảng khởi tạo ứng dụng doanh nghiệp ASP.NET Core MVC & jQuery

ASP.NET Zero là nền tảng phát triển ứng dụng web doanh nghiệp được xây dựng trên ASP.NET Core và Entity Framework Core
, cung cấp kiến trúc đa tầng hoàn chỉnh, bảo mật sẵn có, và nhiều module hệ thống tích hợp sẵn (User, Role, Tenant…).



## Mục lục
1. [Giới thiệu chung](#-giới-thiệu-chung)
2. [Lợi ích của ASP.NET Zero](#-lợi-ích-của-aspnet-zero)
3. [Nhược điểm / Hạn chế](#-nhược-điểm--hạn-chế)
4. [Các tính năng chính](#-các-tính-năng-chính)
5. [Cấu trúc kiến trúc hệ thống](#-cấu-trúc-kiến-trúc-hệ-thống)
6. [Công nghệ sử dụng](#-công-nghệ-sử-dụng)

---

## Giới thiệu chung

ASP.NET Zero được phát triển bởi Volosoft – đơn vị tạo ra framework ABP (ASP.NET Boilerplate).  
Nó là phiên bản thương mại nâng cao của ABP, cung cấp sẵn nền tảng hoàn chỉnh cho các ứng dụng doanh nghiệp như ERP, CRM, HRM, MES,...

### Mục tiêu
> Giúp lập trình viên bắt đầu nhanh một dự án ASP.NET Core phức tạp với:
- Kiến trúc sạch, tách lớp rõ ràng
- Tích hợp đa người dùng, đa tenant
- Sẵn UI/UX Metronic theme
- Bảo mật, logging, phân quyền đầy đủ

---

##  Lợi ích của ASP.NET Zero

| Lợi ích |
 - Kiến trúc sẵn sàng : Multi-layer (UI, Application, Domain, Entity Framework) rõ ràng, tuân thủ SOLID.
 - Phát triển nhanh : Có sẵn code template, CRUD generator, Power Tools sinh code tự động.
 - Bảo mật tích hợp : Identity, JWT Token, Two-Factor Auth, LDAP, External Login, Permission-based authorization. 
 - Hỗ trợ đa tenant (multi-tenancy) : Dễ dàng phát triển ứng dụng SaaS phục vụ nhiều khách hàng khác nhau. 
 - Quản trị sẵn có : Trang quản lý người dùng, vai trò, ngôn ngữ, cấu hình, gói dịch vụ. 
 - Tích hợp real-time : Hỗ trợ SignalR cho chat, thông báo tức thì. 
 - Dashboard mạnh mẽ : Sẵn Metronic Admin UI với chart, widget, theme. 
 - Tương thích DevOps : Hỗ trợ build CI/CD, publish Azure/IIS/Docker. 

---

## Nhược điểm / Hạn chế

| Hạn chế |

-  Không miễn phí hoàn toàn : Bản đầy đủ yêu cầu license thương mại(demo chỉ giới hạn tính năng). 
-  Độ phức tạp cao : Cấu trúc nhiều tầng, đòi hỏi hiểu biết vững về kiến trúc, dependency injection, EF Core.
-  Tùy biến theme khó : Dựa trên Metronic, việc đổi giao diện cần chỉnh nhiều file JS/CSS. 
-  Nặng và nhiều dependency : Không thích hợp cho project nhỏ hoặc microservice đơn giản. 
- Ít tài liệu tiếng Việt Cần tham khảo chủ yếu từ docs chính thức hoặc mã nguồn. 

---

##  Các tính năng chính

### 1. Authentication & Authorization
- Login / Register / Forgot Password / Two-Factor Authentication  
- External Login (Google, Microsoft, LDAP, Azure AD)
- Permission-based Access Control
- Role management & User management

### 2. Multi-tenancy
- Phân chia dữ liệu, người dùng theo từng tenant (công ty)
- Quản lý subscription, package, billing

### 3. Settings & Configuration
- Cấu hình riêng cho từng tenant hoặc host
- Lưu cài đặt động (Database hoặc file)

### 4. Entity & Repository
- Tích hợp sẵn Entity Framework Core
- Repository pattern & Unit of Work
- Dynamic Entity Parameter

### 5. Audit & Log
- Ghi lịch sử thay đổi (Entity History)
- Audit login/logout, API call, exception log

### 6. UI/UX
- Sử dụng Metronic Admin Theme
- Bootstrap 4/5, jQuery, Datatables
- Dynamic menu, layout, modal CRUD

### 7. Power Tools & Code Generator
- Sinh code CRUD, form, modal tự động  
- Hỗ trợ quan hệ Master-Detail  
- Hỗ trợ mở rộng entity hiện có

### 8. Integration & API
- Swagger UI, GraphQL API, Webhook, SignalR
- API Token Authentication, refresh token

---

##  Cấu trúc kiến trúc hệ thống
aspnet-core/
├── src/
│ ├── MyCompany.MyProject.Application → Business logic, DTOs
│ ├── MyCompany.MyProject.Core → Domain entities, interfaces
│ ├── MyCompany.MyProject.EntityFramework → Data access, migrations
│ ├── MyCompany.MyProject.Web.Mvc → Web UI (ASP.NET Core MVC)
│ └── MyCompany.MyProject.Web.Host → API host (for Angular/SPA)
│
├── test/ → Unit & Integration tests
└── libman.json, package.json → Frontend dependencies

