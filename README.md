# unity_art_gallery
ANSI escape sequences can be used to
You can color the output of the terminal and rewrite the output.

I used this to create "Kirby".

# DEMO

![Qiita](https://i.imgur.com/kEH021j.png "Qiita")

It may look like an alarm clock, but it is "Kirby".(^^)

# Features

You can do this only by writing escape sequences. For example, by writing like this, you can represent the pink part of the skin.

```ruby
print "\033[48;5;",225.to_s, "m","  \033[0m"
```
We just wrote the escape sequence one pixel at a time according to the way the escape sequence is written.

# Requirement

* Ruby 2.6.8

# Installation

No libraries used

# Usage

Copy and paste "Draw_24bit.rb".

Please create ruby code named "Draw_24bit.rb".

Run "Draw_24bit.rb"

```bash
ruby Draw_24bit.rb
```

# Note

I don't test environments under Linux and Windows.

# Author

* Nakazi

# License

"ANSI escape sequences" is under [ANSI escape sequences](https://en.wikipedia.org/wiki/ANSI_escape_code#External_links).

Let's display the dots on the terminal!

Thank you!