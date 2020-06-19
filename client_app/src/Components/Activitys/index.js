import React, { Component } from 'react'
import ActivityContainer from './ActivityContainer';
import {connect} from 'react-redux'
import {GetActivities} from '../../Store/Activity/ActivityAction'

class index extends Component {
   
  componentDidMount() {
      this.props.GetActivities();
  }
    render() {
        console.log(this.props)
        return (
            <div>
                <ActivityContainer {...this.props}/>
            </div>
        )
    }
}
const mapStateToPorps = state => {
    return {activity: state.activity}
}
const mapDispatchToProps = dispatch => {
    return {
     GetActivities : () => dispatch(GetActivities())
    }
  } 
export default connect(mapStateToPorps,mapDispatchToProps)(index)
