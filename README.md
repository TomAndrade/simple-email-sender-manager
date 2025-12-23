# Simple email sender for tests

>Status: updating ♻️<br>
>Version: 1.3<br>
>Date released: 12/16/2025

### Update 1.3
* Media and attachments support

### Update 1.2
* English language added.

### Update 1.1
* UI Changes.

## What does it do? - Purpose
Opens a window as a window to send emails with HTML language support.

## Content
Single form no dependencies. One menu, two languages: PT-BT; EN-US. One textBox as Subject. RichTextBox as body.

## How does it work? - Behavior
The program is in Portuguese-Brazil language.
Check "This email contains HTML" box to activate HTML content:
* "B" button changes the selected text in **bold**. "I" changes in _italic_. "U" in <ins>underlined</ins>.
* "Media" button adds media files in the body.

The "Send email" button works when subject is not null only.
The "Annex/ Attachment" adds files.

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
