import {GET_ALL_ACTIVITY} from './type';

const INITIAL_STATE = {
    Activities: {},
    Processing: false,
}
const  ActivityReducer = (state = INITIAL_STATE,action) => {
    
    switch(action.type)
    {
        case GET_ALL_ACTIVITY:
            return {...state,Activities: action.payload}
        default :
        return state;
    }
}
export default ActivityReducer;