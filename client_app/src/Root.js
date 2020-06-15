import React from 'react';
import {Provider} from 'react-redux';
import {createStore,applyMiddleware }  from 'redux';
import reducers from './Store/store';
import thunk from 'redux-thunk'



const Root = (props) => {
    return(
        <Provider store={createStore(reducers,{},applyMiddleware(thunk))}>
            {props.children}
        </Provider>
    );
}
export default Root;