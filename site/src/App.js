import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1>work from home logger</h1>
        <img src={require("./example.png")} className="App-logo" alt="screenshot of wfh-log" />
        <p>
          A windows app to log work from home hours for the Australian Tax Office (ATO).
        </p>
        <span>
          <a 
            className="App-link"
            href="https://github.com/dylan-george-field/work-from-home-logger/releases/latest/download/wfh-log.exe"
            target="_blank"
            rel="noopener noreferrer">
              Download 
          </a>
           | 
          <a
           className="App-link"
           href="https://github.com/dylan-george-field/work-from-home-logger/wiki"
           target="_blank"
           rel="noopener noreferrer">
            Wiki
          </a>
        </span>
        <p>Put it in the windows startup folder.</p>
      </header>
    </div>
  );
}

export default App;
