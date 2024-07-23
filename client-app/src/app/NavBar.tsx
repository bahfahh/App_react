import * as React from 'react';
import { Button, Container, Menu } from 'semantic-ui-react';
export interface IAppProps {
}
export default function NavBar() {
    return (
        <Menu fixed='top' inverted>
            <Container>
                <Menu.Item as='a' header>
                    <img src="/assets/categoryImages/logo.png" alt="logo" style={{marginRight: '10px'}}/>
                    Reactivities
                </Menu.Item>
                <Menu.Item name='Activitys'>
                </Menu.Item>
                <Menu.Item >
                    <Button positive content='Create Activity' />
                </Menu.Item>
            </Container>
        </Menu>
    );
}
