import { useState, useEffect } from 'react'
import './App.css'

function App() {
  const [greeting, setGreeting] = useState('')
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(Error);


  useEffect(() => {
    const fetchGreeting = async () => {
      try {
        const response = await fetch('http://localhost:5010/api/greeting');

        if (!response.ok)
          throw new Error('HTTP error! status: ${response.status}');

        const data = await response.json();
        console.info(data);
        setGreeting(data.message);


      } catch (e: unknown) {
        console.error("Error getching greeting:", e)
        setError(e as Error);
      }
      finally {
        setLoading(false);
      }
    };

  fetchGreeting();

  }, []);

  return (
    <>
      <h1>Conexión React - .NET</h1>
      <div className="card">
        {loading && <p> Cargandon saludo desde el backend...</p>}
        {error.message && <p>Error al cargar el saludo: {error.message}</p>}
        {greeting && <p> Mensaje del Backend: <strong>{greeting}</strong></p>}
      </div>
    </>
  )
}

export default App
