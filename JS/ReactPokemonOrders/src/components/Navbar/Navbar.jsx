import { NavLink } from "react-router-dom";
import { useUser } from "../../context/UserContext";

const Navbar = () => {

    const { user } =    useUser();

    return (
        <nav>
            <ul>
                <li>Your Pokemon</li>
            </ul>
            { user !== null &&
                <ul>
                    <li>
                        <NavLink to='/orders'>Pokemon</NavLink>
                    </li>
                    <li>
                        <NavLink to='/profile'>Profile</NavLink>
                    </li>
                </ul>
            }
        </nav>
    )
}

export default Navbar;