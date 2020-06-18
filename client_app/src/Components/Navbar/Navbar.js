import React from 'react';
import {Menu, Container,Button} from 'semantic-ui-react';


 const Navbar = () => 
 {
    return (
        <Menu inverted fixed="top">
            <Container>
                 <Menu.Item header> 
                    <img src="/assets/Images/logo.png" alt="logo"/>
                    Facebook Clone
                 </Menu.Item>
            <Menu.Item 
                name='Activites'
            />
            <Menu.Item>
                <Button positive content="Create Activity"/>
            </Menu.Item>
            </Container>
           
        </Menu>
    )
}
export default Navbar;