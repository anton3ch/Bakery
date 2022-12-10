# Pierre's Bakery

#### Creates Pierre's Bakery Orders

#### By [Anton Ch](https://github.com/anton3ch)

## Technologies Used

- C#
- .NET 6.0
- dotnet script REPL

## Description

Pierre's Bakery lets users select what items they want to buy and calculates total cost based on specials.

## Setup/Installation Requirements

- Clone this repository to your Desktop:
  1. Your computer will need to have GIT installed. If you do not currently have GIT installed, follow [these](https://docs.github.com/en/get-started/quickstart/set-up-git) directions for installing and setting up GIT.
  2. Once GIT is installed, clone this repository by typing following commands in your command line:
     ```
     ~ $ cd Desktop
     ~/Desktop $ git clone https://github.com/anton3ch/Bakery.Solution.git
     ~/Desktop $ cd Bakery.Solution
     ```
- Install the [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Create .gitignore file:
  ```
   ~/Desktop/Bakery.Solution/ $ touch .gitignore
   ~/Desktop/Bakery.Solution/ $ echo "*/obj/
   */bin/"
  ```

- Build the project:
  ```
   ~/Desktop/Bakery.Solution/Bakery.Tests $ dotnet restore
  ```
- Run the project
  ```
   ~/Desktop/Bakery.Solution/Bakery $ dotnet run
  ```

## Known Bugs



## License

[ISC](https://opensource.org/licenses/ISC)

Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted, provided that the above copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.

Copyright (c) 12/09/2022 Anton Ch