# Simple email sender for tests

>Status: updating ♻️<br>
>Version: not applicable<br>
>Date released: 12/16/2025

## What does it do? - Purpose
Opens a window as a window to send emails with HTML language support.

## Content
Single form no dependencies. One menu, two languages: PT-BT; EN-US. One textBox as Subject. RichTextBox as body.

## How does it work? - Behavior
The program is in Portuguese-Brazil language.
Check "This email contains HTML" box to activate HTML content:
* "B" button changes the selected text in **bold**. "I" changes in _italic_. "U" in <ins>underlined</ins>.
* "Media" button adds media files in the body. (unavailable for now - WIP).

The "Send email" button works when subject is not null only.
The "Annex" button is currently unavailable (WIP). 

## Observations:

* Languages can be added in: `static string[] languages = { "portuguese", "english" };`
   * Translations were manually created.
   * `languages[0]` is portuguese;.
   * `languages[1]` is english.
* Isn't necessary use .resx files.
* Use `mailMessage.To.Add(new MailAddress("anEmail@email.com"));` to perform controlled mass firings.
* Don't forget to create a custom credential (pass) for this purpose: `smtpClient.Credentials = new NetworkCredential("anEmail@email.com", "pass");`

## What was used? - Resources
GUI          | .NET  | SQL | Web
------------ | ----- | --- | ---
Windows Forms| v.8.0 | No  | NET.Mail
