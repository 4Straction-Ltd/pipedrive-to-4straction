# pipedrive-to-4straction
General component that integrates pipedrive sales pipeline to 4straction management decision making

How this formatting works?

Parts in this implementation:

1. 4Straction API implementation using swagger compatible client API
2. Pipedrive API implementation using modelled classes
3. Organize and map Pipedrive pipelines and stages into usable items
4. Push needed information to 4straction


Other stuff:

- How to update 4straction client when API changes:

java -jar swagger-codegen-cli-2.2.1.jar generate  -i 4straction.json -l csharp

=> Then limited entities to a subset..
