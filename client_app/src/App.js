import React from 'react';
import logo from './logo.svg';
import Navbar from './Components/Navbar/Navbar'
import Activity from './Components/Activitys'
import { Container } from 'semantic-ui-react';

function App() {
  return (
    <div >
      <Navbar />
      <Container>
        <Activity />
      </Container>
    </div>
  );
}

export default App;
