# pipedrive-to-4straction

## Getting started

### 4S-API-User-ID

4Straction user account (email). Required

### 4S-API-User-Password

4Straction user account password. Required. Soon availability to also use authkey for authentication

### 4S-API-Partner-Key

Partner key which is partner spesific

### 4S-API-CompanyID-Override

Optional. If user has access to multiple organizations, then pass internal key for organization. You can also
use business id value with header: 4S-API-Organization-Identifier-Override


## Pipelines and stages

Pipedrive is organized into pipelines and stages. 4straction will soon support these structures in UI configuration
format but now you need to manually setup settings which include:

- authkey
- root url for your client instance
- pipelines that you use
- stages where you want to pick up data

Currently settings assume that you can pick up:
- monetary value of deals
- count of deals in spesific phase


## Mapping to 4straction structures

4Straction Business Insights work with indicators and corporate links. Examples of indicators:

- quote base
- revenue
- contract base
- number of quotations

Corporate links are fixed and includes:

External world:
- Customers
- Partners
- Suppliers
- Competitors
- Other Players

Internal world:
- Products
- Legal Units
- Functions

By modifying corporate link when passing items to PerformanceIndicatorStorage, system calculates unique set of
links when merging information to 4straction. If you first read pipelines that are organized by countries,
you can then modify link to include product line or customer segment information.



## Other considerations

How can you update 4straction client library?

- pick up swagger-codegen
- pick up latest yaml-description file from 4straction.io
- Run "java -jar swagger-codegen-cli-2.2.1.jar generate -i 4straction.json -l csharp"

Currently only limited/minimal entities are included in this project

