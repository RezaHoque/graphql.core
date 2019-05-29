# graphql.core
GrapgQL with asp.net core

# how to run
Clone the repo.

Fix the DB connection properties on appsettings.json.

Run Update-Database in the Package Manager console.

Add some data in the Author Table.

Run the site and browse to https://localhost:44367/ui/playground

# call the api from postman
Create a new "POST" request in postman.

URL: https://localhost:44367/graphql

Headers: Content-Type: application/json

RAW Body: {
"query":"query{authors{name,country}}"
}


