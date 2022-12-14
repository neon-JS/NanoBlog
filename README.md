# NanoBlog _[wip]_
A simplistic blogging system

## About 
NanoBlog is a blogging system on file basis, therefore it doesn't use a database, cookies or even subpages.
This is achived in 2.5 steps:

1. Creating, reading, updating or deleting all content via API and storing them as files. 
This allows us to configure the blog either completely via API or partly on the filesystem itself.  
Content files are separated into three folders:
  - _BlogFiles/Structure_, which contains the HTML header (_html-header.txt_), content header (_header.txt_) and footer (_footer.txt_).
  Those files always exist for a blog and can be updated (though not be deleted) via API.
  - _BlogFiles/Posts_, which contains all posts that were created. Post files are named automatically so that they're sortable 
  by creation date. In contrast to structure files, posts can also be deleted.
  - _BlogFiles/Assets_, which contains all assets (currently only images) that can be included (via `<img>`-tag) in the posts or structure.
  Asset files are limited by type (currently: _png_, _jpg_, _gif_) and type checked by file extension, magic bytes and given MIME type.
  These files can also be updated or deleted and named automatically (extension is preserved).

2. Composing all files into a single HTML file which then can be served by a webserver.
The resulting file will be exported into _Export/index.html_.

2.5 Copying all asset files into the _Export/Assets_ folder so that they can be served too.

## Details
- The API is secured via bearer token. This token must be configured before starting NanoBlog either via _appsettings.json_ or environment variables.
  **Make sure to use a long and secure token! Also make sure that possible brute forcing is prevented by firewall, IPS and rate limiting!**

### API documentation
_Coming soon!_

## Setup
**DO NOT USE IN PRODUCTION! THIS PROJECT IS CURRENTLY BEING DEVELOPED AND TESTED BY ME!**

### Docker
- `cd docker/`
- `mkdir export/`
- `cp .env.example .env`
- set _AuthenticationToken_ in `.env`
- `docker compose up`

### .NET
- `cd src/`
- set _AuthenticationToken_ in _NanoBlog/appsettings.json_ (or _NanoBlog/appsettings.Development.json_)
- `dotnet run .` or `dotnet test .`

## Issues, help or security related stuff
If you want to give me any relevant information to this project, feel free to either create an issue or write me an e-mail: novembermikefive /at/ gmail.com .
But again: **DO NOT USE IN PRODUCTION! THIS PROJECT IS CURRENTLY BEING DEVELOPED AND TESTED BY ME!**

## License
MIT
