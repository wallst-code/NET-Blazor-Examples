# NET-Blazor-Examples
Some simple projects in .NET and Blazor (C#)


<h2> ⚠ A Simple Blazor Password App. <span style="color:#ff0000;">IT IS NOT SECURE</span> - <span style="color:#ff0000;">only for demonstration</span>. ⚠</strong></h2>
<h3>
	Problem:&nbsp;</h3>
<ul>
<li>&nbsp; Password managers are a pain.&nbsp;</li>
<li>&nbsp; They keep getting hacked.&nbsp;</li>
<li>&nbsp; How could I use the same general &ldquo;seed&rdquo; information while still having a different password generated for each website?&nbsp;</li>
</ul>
<h3>
	Solution:</h3>
<ol>
<li>If I did not save my passwords in a container in the cloud or on my system, then there would be nothing for hackers to steal.</li>
<li>Maintain the same general security &ldquo;seeds&rdquo;, because this is what people do anyway (we are lazy).</li>
<li>Create varied passwords by using the site that the password is connected to.</li>
<li>Thus, when I need my password for a site, I just use my lazy security seeds and type in the site name.&nbsp;</li>
<li><strong>Embrace our laziness -- work with human behavior not against it. 🧠</strong></li>
</ol>
<h3>
	So What?</h3>
<p><strong><span style="font-size:16px;"><span style="font-family:arial,helvetica,sans-serif;">💡 I do not need to remember a difficult password -- just few pieces of standardized info (seed, key, and pin) and the website name.&nbsp;</span></span></strong></p>
<h3>
	Issues:&nbsp;</h3>
<ol>
<li>Needs a bit of work on the security and look and feel fronts.</li>
<li>Some vital aspects may remain in memory.</li>
<li>Security features would need to be added.</li>
<li>It likely would not be secure as an app for the public (too simple).&nbsp;</li>
</ol>
<h3>
	Potential Next Iterations and Refactoring Needs:&nbsp;</h3>
<ol>
<li>Improve dependency injection aspects - it&#39;s a bit clunky.</li>
<li>Add some helpful features like a character counter for the input areas.</li>
<li>Improve IV for the cryptography - it lacks variability.</li>
<li>People remember visual data - find a way to incorporate that.</li>
<li>For example, use a sequence of RGB color codes to change certain aspects.</li>
<li>Could have a type of key pad like UI that shows a sequence of 10 pics rather than numbers. After a selection, a new set of 10 would populate and so on&hellip;</li>
<li>People can remember Red &rarr; Frog &rarr; Moon&hellip;</li>
<li>Simplify code and tighten it up.&nbsp;</li>
</ol>
<div>
	<em>*The next iteration will likely be in C++ (maybe Golang).&nbsp;</em></div>
<div>
	<h2>
		<strong><span style="color: rgb(255, 0, 0);">👉 Remember This App IS NOT SECURE</span>&nbsp;-&nbsp;<span style="color: rgb(255, 0, 0);">only for demonstration. ⚠</span></strong></h2>
</div>
<h3>
	Steps to use the app:</h3>
<ul>
<li>Start the app.</li>
<li>Enter a 10-character &quot;seed&quot; password (i.e., the lazy one we all use any way).</li>
<li>Enter a 16-character &quot;key&quot;.</li>
<li>Enter a 4-digit pin.</li>
<li>Enter the site (or store) that the password is connected to (min. 3-characters).</li>
<li>(Optional) You can shorten the length of the password.</li>
</ul>
<br />


<img width="760" alt="BlazorPWApp1" src="https://user-images.githubusercontent.com/69335472/219127441-ada404c3-0229-45d4-a6c3-0cc2d132c28e.png">
<img width="846" alt="BlazorPWApp2" src="https://user-images.githubusercontent.com/69335472/219127454-872ff8ce-f2cc-48d1-bd6c-00c8d9579534.png">


<p><a href="https://www.linkedin.com/in/senit-lutgen/"> LinkedIn Profile: Senit Lutgen</a></p>
