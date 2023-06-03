﻿Create Table CustomerInfo(
客户编号 char(6) Primary key,
客户姓名 varchar(20) NOT NULL,
客户密码 varchar(20) NOT NULL,
性别  char(2),
所在地址 varchar(50) NOT NULL,
联系电话 varchar(12),
邮箱 varchar(30),
VIP bit default'0',
备注 text
)
Create Table GoodsInfo(
商品编号 char(8) Primary key,
商品类别 char(20) NOT NULL,
商品名称 varchar(50) NOT NULL,
品牌 varchar(30),
单价 float,
库存量 int NOT NULL,
备注 text
)
Create Table list_from_C(
客户编号 char(6) NOT NULL,
商品编号 char(8) NOT NULL,
订购时间 datetime ,
数量 int,
PRIMARY KEY(客户编号,商品编号),
foreign key (客户编号) references CustomerInfo(客户编号),
foreign key (商品编号) references GoodsInfo(商品编号),
)