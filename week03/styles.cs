
:root {
  --primary-color: #006994;
  --accent1-color: #023047;
  --accent2-color: #8ecae6;
  --heading-font: 'Georgia', serif;
  --body-font: 'Arial', sans-serif;

 {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}


body {
  font-family: var(--body-font);
  color: var(--accent1-color);
  background-color: #f8f9fa;
}


header, main, footer {
  width: 840px;
  margin: 0 auto;
}


header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 16px;
}

nav a {
  margin: 0 12px;
  text-decoration: none;
  color: var(--primary-color);
  font-weight: bold;
}


.hero {
  position: relative;
}

.hero img {
  display: block;
  width: 100%;
  height: auto;
}

.hero h1 {
  position: absolute;
  top: 20px;
  width: 100%;
  padding: 16px;
  text-align: center;
  opacity: 0.8;
  background-color: var(--accent1-color);
  color: white;
  font-family: var(--heading-font);
}

.hero article {
  position: absolute;
  bottom: 20px;
  left: 20px;
  right: 20px;
  background-color: rgba(255, 255, 255, 0.8);
  padding: 12px;
  border-radius: 8px;
}

.hero article img {
  float: right;
  width: 125px;
  margin-left: 12px;
  border-radius: 8px;
}


h2 {
  font-family: var(--heading-font);
  color: var(--primary-color);
  margin: 16px 0;
}

nav, p, section, article {
  margin: 16px;
  padding: 8px;
}


footer {
  text-align: center;
  padding: 16px;
  margin-top: 20px;
  border-top: 2px solid var(--primary-color);
}

.socialmedia a {
  text-decoration: none;
  margin: 0 8px;
}
