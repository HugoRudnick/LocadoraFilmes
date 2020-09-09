import React from 'react'
import logo from './logo.svg'
import './App.css'
import { store } from './Actions/Store'
import { Provider } from 'react-redux'
//import Usuario from './Components/Usuario'
//import Genero from './Components/Genero'
import Filme from './Components/Filme'
import { Container } from '@material-ui/core'
import { ToastProvider } from 'react-toast-notifications'

function App () {
  return (

    <Provider store={store}>
      <ToastProvider autoDismiss={true}>
        <Container maxWidth="lg">
          <Filme />
        </Container>
      </ToastProvider>
    </Provider>

  )
}

export default App
